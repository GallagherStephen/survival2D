using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add this for scene management for unity
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    
//== on_click events ==

public void Back_OnClick()
    {
        SceneManager.UnloadSceneAsync("Options menu");
        
    }




}
