using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public int health = 100; //enemy health
    public GameObject deathEffect;

    
    public float speed;
    public bool MoveLeft;

    public void TakeDamage(int damage) //takes in how much damage to take 
    {
        health = health - damage; //subtract from our health

        if ( health <= 0)
        {
            Die();
        }
    }

    //death effect and kill the enemy
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update()
    {
        if (MoveLeft)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0,0);
        }
        else //move right(-2)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0,0);

        }
    }



}
