using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //needed for loading a new scene
public class enemyScript : MonoBehaviour
{

    public int health = 100; //setting enemy health

     [SerializeField] private GameObject deathEffect;
     [SerializeField]private float deathEffectDuration = 1.0f;
     [SerializeField] private string newLevel;

    // delegate type to use for event
    public delegate void EnemyKilled(enemyScript enemy);

    // create static method to be implemented in the listener
    public static EnemyKilled EnemyKilledEvent;



    public float speed;
     public bool MoveLeft;

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



    //=======================================================================
    // ENEMY TAKE DAMAGE + add up score when shot
    //=======================================================================
    public void TakeDamage(int damage) //takes in how much damage to take 
    {
        scorescript.scoreValue += 10; //adds up our score when enemy is shot
        health = health - damage; //subtract from our health

        if ( health <= 0)
        {
            //Die();
            Destroy(gameObject);
          
        }
    }


    //=====================================================================
    //death effect and kill the enemy
    //======================================================================
    private void OnTriggerEnter2D(Collider2D Hit)
    {
        var player = Hit.GetComponent<move2d>();
        var bullet = Hit.GetComponent<bulletScript>();

        if (bullet)
        { 
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, deathEffectDuration); //telling the death effect how long when used
        Destroy(gameObject);
        }

        if (player)  // if (player != null)
        {
            // destroy the player 
            Destroy(player.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(newLevel); //load new scene level
        }

    }

    private void PublishEnemyKilledEvent()
    {
        // make sure somebody is listening
        if (EnemyKilledEvent != null)
        {
            EnemyKilledEvent(this);
        }
    }



}
