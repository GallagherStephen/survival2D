using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add this for scene management for unity
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    //handle button events
    // start button, options button 
    //use scenemanager to load and unload scenes
    //all methods are static , subscribe to events
    //like sceneloaded,sceneUnloaded,SceneChanged for custon logic
    //use LoadSceneAsync to load a new scene

    //SceneManager is in unityEngine.SceneManagement library


    // == OnClick events ==

public void Start_OnClick()
    {
        SceneManager.LoadSceneAsync("Game"); //passing in the name of the scene as displayed in unity
    }

    public void Options_OnClick()
    {
        SceneManager.LoadSceneAsync("Options Menu", LoadSceneMode.Additive); //passing in the name of the scene as displayed in unity as an overlay to game not a new scene entirely
    }
}
