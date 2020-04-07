using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //needed for loading a new scene

public class killPlayerScript : MonoBehaviour{

    [SerializeField] Transform spawnPoint;
   

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player")) //looking for player tag 
        {
            col.transform.position = spawnPoint.position;
            
        }
    }
}
