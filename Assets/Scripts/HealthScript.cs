using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthScript : MonoBehaviour
{
    //variables
    public int health;
    public int numOfLivesHeads; //the number of heads/lives shown

    public Image[] heads; //heads being the lives
    public Sprite fullLives;
    public Sprite emptyLives;


    void Start()
    {
        
    }
    
    void Update(){
        //=====================================
        //making sure the player does not have
        //more health than the amount of heads

        if(health > numOfLivesHeads)
        {
            health = numOfLivesHeads;
        }

        //======================================

    for( int i = 0;i < heads.Length; i++) {


            //====================================
            //determines if it shows a full life
            //health or a missing life head

            if (i< health)
            {
                heads[i].sprite = fullLives;
            }
            else
            {
                heads[i].sprite = emptyLives;
            }
            //====================================

            if(i< numOfLivesHeads){ // if i is smller than the number of hearts the player has 
                heads[i].enabled = true; //if i is smaller then u want the heart of index i to be visable
            }else
            {
                heads[i].enabled = false; //if bigger u want them to be hidden 
            }
        }
    }
}
