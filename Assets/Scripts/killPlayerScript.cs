using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
