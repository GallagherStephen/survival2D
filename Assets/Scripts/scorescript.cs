using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    //Variables
    public static int scoreValue = 0;
    Text score;


    void Start()
    {
        //reference to score text object
        score = GetComponent<Text>(); 
    }
   
    void Update()
    {
        //setting text value to score 
        //and amount of score we earn while playing
        score.text = "Score" + scoreValue;
    }
}
