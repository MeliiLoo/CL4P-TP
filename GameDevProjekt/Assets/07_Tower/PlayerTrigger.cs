using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public EnemySkills inRange;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D enter)
    {
        CharacterController player = enter.GetComponent<CharacterController>();
        if (player != null)
        {
            inRange.inRange = true;

        }

    }
}
