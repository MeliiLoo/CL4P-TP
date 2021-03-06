﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    [SerializeField]
    private GameControl gameCo;
    public AudioClip DeathTowerSound; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sterben
        if (health < 1)
        {
            SoundManager.instance.RandomizeSfx(DeathTowerSound);
            gameCo.score += 10;
            Destroy(this.gameObject);


        }

    }


    public void TakeDamage(int damage)
    {

        health -= damage;
        
    }
}
