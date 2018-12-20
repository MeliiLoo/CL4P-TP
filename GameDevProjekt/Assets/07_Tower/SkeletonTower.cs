﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonTower : MonoBehaviour
{   [SerializeField]
    GameObject bullet;

    [SerializeField]
    float fireRate = 1f;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire() {
        if (Time.time > nextFire) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
