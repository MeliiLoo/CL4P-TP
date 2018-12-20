using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDeath : MonoBehaviour {

	public GameControl gameCo;
    public AudioClip DeathJump1; 
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Death()
    {
        SoundManager.instance.RandomizeSfx(DeathJump1);
        Destroy(this.gameObject);
		gameCo.score +=2;
    }
}
