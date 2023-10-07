/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program controls how selected game objects
 *      would spawn in the game.
 * 
 * How to use the script:
 *      - Create a Spawner object for each object to be spawned
 *      - Attach the script to the Spawner object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // object to be generated (can be set via the Inspector)
    public GameObject prefab;

    // boundaries of object generation
    public Transform borderRight;
    public Transform borderLeft;

    // spawn interval and a timer
    public float spawnInterval;
    public float spawnTimer;

    // continuously spawn the objects with a delay in between of the spawns
    void Update()
    {
        // decrements the spawn timer
        spawnTimer -= Time.deltaTime;

        // if spawnTimer goes below 0, spawn another object
        if (spawnTimer <= 0)
        {
            Spawn();
        }
    }

    // method to handle the actual spawn mechanic
    void Spawn()
    {
        // selects a random x-coordinate (within the set borders) where the object would spawn
        float randomX = Random.Range(borderLeft.position.x, borderRight.position.x);

        // assigns the random x-coordinate to the x-coordinate of the object
        Vector2 newPosition = transform.position;
        newPosition.x = randomX;

        // clones the object and puts in the assigned random x-coordinate
        Instantiate(prefab, newPosition, Quaternion.identity);
        // restarts the timer to the set spawn interval
        spawnTimer = spawnInterval;
    }
}
