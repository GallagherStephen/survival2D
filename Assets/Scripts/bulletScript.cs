using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public int damage = 40; //default damage to enemy ( CAN CHANGE IF U WANT)
    public Rigidbody2D rb;
    public GameObject impactEffect; //effect
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyScript enemy = collision.GetComponent<enemyScript>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation); //animation for each hit to an object 


        Destroy(gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}