using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void ButtonMoveScene(string level)
    {
        if(level == "Game")
        {
            scorescript.scoreValue = 0; //sets the score back to 0 when level1/game scene is called
        }
        SceneManager.LoadScene(level); //load the level we select on unity screen
    }
}
