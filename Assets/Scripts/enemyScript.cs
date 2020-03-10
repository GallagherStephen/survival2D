using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public int health = 100; //setting enemy health
    public GameObject deathEffect;
    public float speed;
    public bool MoveLeft;





    //=======================================================================
    // ENEMY TAKE DAMAGE + add up score when shot
    //=======================================================================
    public void TakeDamage(int damage) //takes in how much damage to take 
    {
        scorescript.scoreValue += 10; //adds up our score when enemy is shot
        health = health - damage; //subtract from our health

        if ( health <= 0)
        {
            Die();
        }
    }
    

    //=====================================================================
    //death effect and kill the enemy
    //======================================================================
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
    void Update()
    {   
        
        //==========================================================
        //MOVEMENT
        //==========================================================
        if (MoveLeft) //(2)(positive)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0,0);
        }
        else //move right(-2)(negative)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0,0);

        }
        
    }



}
