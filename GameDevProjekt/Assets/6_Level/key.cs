﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class key : MonoBehaviour {

    public GameControl gc;
    public int value;
    public Text keyText;
    [SerializeField]
    private GameObject keyObject;

    void Start(){

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.CompareTag("Player"))
        {  
            gc.gotKey = value;
            gc.score +=10;
            Destroy(this.gameObject);           
        }
    }
}
