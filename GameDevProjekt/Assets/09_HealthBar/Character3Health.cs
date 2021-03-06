﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character3Health : MonoBehaviour
{
    [SerializeField]
    private Character character;

    public AudioClip GetHit2; 
    public bool isDead;

    public float health;
    public float maxHealth;

    public Image healthBar;

    public ChangeCharacter cc;


    void Start()
    {
        maxHealth = character.health;
        health = maxHealth;
        
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JumpDeath enemy = collision.collider.GetComponent<JumpDeath>();

        if (enemy != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                if (point.normal.y >= 0.9f)
                {

                    enemy.Death();
                }
                else
                {
                    health -= 10;
                    SoundManager.instance.RandomizeSfx(GetHit2);
                    HealthBar();

                    if (health < 1)
                    {
                        cc.isDead3 = true;
                    }



                }
            }
        }
    }

    public void HealthBar() {

        healthBar.fillAmount = health/maxHealth;

    }
    public void TakeDamage(int damage)
    {

        health -= damage;
        HealthBar();
    }
}

