﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonBullet : MonoBehaviour
{
    [SerializeField]
    float speed = 7f;
    Rigidbody2D rb;
    CharacterController target;
    Vector2 direction;
    [SerializeField]
    int damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<CharacterController>();
        direction = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(direction.x, direction.y);


    }

    
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        Character1Health player = hit.GetComponent<Character1Health>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(this.gameObject);

        }

    }
}