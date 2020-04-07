using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform startingBulletPoint; //OBJECT CREATED STATING STARTING POINT
    public GameObject bulletPrefab;       //BULLET OBJECT IN PREFAB
    private AudioSource audioSound;

    
    //=====================================================
    // Shoot using the left click when pressed
    // Update is called once per frame
    //=====================================================
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
            audioSound.Play();
        }
    }

    //=====================================================
    //SHOOT METHOD
    //=====================================================
    void shoot ()
    {
        //shooting logic
        //create a bullet at the starting bullet position from the prefab
        Instantiate(bulletPrefab, startingBulletPoint.position, startingBulletPoint.rotation);
        audioSound = GetComponent<AudioSource>();
    }


}
