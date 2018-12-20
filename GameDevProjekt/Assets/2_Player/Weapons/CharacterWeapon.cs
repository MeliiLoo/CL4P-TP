using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour {

    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private GameObject bullet;
    public AudioClip PengPengSound1;
    public AudioClip PengPengSound2; 
    

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
            SoundManager.instance.RandomizeSfx(PengPengSound1, PengPengSound2);
        Shoot();
	}

    void Shoot() {

        Instantiate(bullet, firePoint.position, firePoint.rotation);
            
            }
}
