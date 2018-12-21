using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour {

	public GameControl gm;
	public GameObject coin;
    public AudioClip CoinSound1;


	// Use this for initialization
	void Start () {
		
	}
	private void OnTriggerEnter2D(Collider2D collision){
       
        if (collision.gameObject.CompareTag("Player"))
        {
            SoundManager.instance.RandomizeSfx(CoinSound1);
            gm.score +=3; 
		Destroy(this.gameObject);
		}
}
}