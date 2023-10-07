/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program handles the collision between
 *      the collectible game object and the Player.
 * 
 * How to use the script:
 *      - Attach the script to the collectible object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // checks if the collectible object collides specifically with the Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the Player collides with the collectible item, increment Player's points and destroy the item
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.points++;
            Destroy(this.gameObject);
        }
    }
}
