using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public int health = 100; //enemy health
    public GameObject deathEffect;

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

}
