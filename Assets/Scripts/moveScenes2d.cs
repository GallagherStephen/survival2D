using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //needed for loading a new scene

public class moveScenes2d : MonoBehaviour
{

    [SerializeField] private string newLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel); //load new scene level
        }
    }

    
}
