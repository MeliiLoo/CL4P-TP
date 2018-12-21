using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamicFireaball2 : MonoBehaviour {

private Vector2 newForce;
private Rigidbody2D firi;
    [SerializeField]
    private int damage = 10;

	// Use this for initialization
	void Start () {
		firi = gameObject.GetComponent<Rigidbody2D>();
	}
	public
	// Update is called once per frame
	void Update () {

		newForce = new Vector2(-5,0);
	   	firi.AddForce(newForce, ForceMode2D.Impulse);
	}
    void OnTriggerEnter2D(Collider2D hit)
    {
        Character1Health player = hit.GetComponent<Character1Health>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(this.gameObject);

        }

        Character2Health player2 = hit.GetComponent<Character2Health>();
        if (player2 != null)
        {
            player2.TakeDamage(damage);
            Destroy(this.gameObject);

        }



        Character3Health player3 = hit.GetComponent<Character3Health>();
        if (player3 != null)
        {
            player3.TakeDamage(damage);
            Destroy(this.gameObject);
        }

    }
}