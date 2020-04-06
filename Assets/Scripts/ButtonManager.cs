using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level); //load the level we select on unity screen
    }
}
