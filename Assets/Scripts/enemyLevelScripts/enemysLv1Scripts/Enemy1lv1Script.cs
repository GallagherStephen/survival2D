using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1lv1Script : MonoBehaviour
{

    public Transform[] spawnpoints; //creating a spawnpoints array
    public GameObject[] monsters; //creating a monster array
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;

    //private Stack<spawnpoint> spawnStack;

    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", 0f, 0f); //spawn a monster every 2 seconds
    }


    //===============================================
    //SPAWN MONSTER METHOD:
    //===============================================
    // Update is called once per frame
    void SpawnAMonster()
    {

        randomSpawnPoint = Random.Range(0, spawnpoints.Length);
        randomMonster = Random.Range(0, monsters.Length);
        Instantiate(monsters[randomMonster], spawnpoints[randomSpawnPoint].position, Quaternion.identity);

    }




}
