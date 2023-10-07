/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program handles the collision between
 *      the obstacle game object and the Player.
 * 
 * How to use the script:
 *      - Attach the script to the obstacle object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // checks if the game object collides specifically with the Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the Player collides with an Obstacle, destroy the Player
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
