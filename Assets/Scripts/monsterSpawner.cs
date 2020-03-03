using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterSpawner : MonoBehaviour
{

    public Transform[] spawnpoints; //creating a spawnpoints array
    public GameObject[] monsters; //creating a monster array
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;
    
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 0f, 2f); //spawn a monster every 2 seconds
    }

    // Update is called once per frame
    void SpawnAMonster()
    {
        randomSpawnPoint = Random.Range(0, spawnpoints.Length);
        randomMonster = Random.Range(0, monsters.Length);
        Instantiate(monsters[randomMonster], spawnpoints[randomSpawnPoint].position, Quaternion.identity);
    }
}
