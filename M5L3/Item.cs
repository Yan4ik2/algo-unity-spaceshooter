/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program handles the collision between
 *      the collectible game object and the Player, 
 *      but this time, updated for the game to 
 *      produce an animation and effect (visual and
 *      sound) when the collectible item is collected.
 * 
 * How to use the script:
 *      - Attach the script to the collectible object
 *      - Assign the pickup effect asset to the pickupEffect
 *          field in the Inspector
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // stores the chosen pickup visual and sound effect
    public GameObject pickupEffect;

    // checks if the collectible object collides specifically with the Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the Player collides with the collectible item, increment Player's points and destroy the item
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.points++;

            // when the collectible item is collected, create an effect on the same position and rotation as the item
            // then destroy the effect after 5s
            GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(effect, 5);

            Destroy(this.gameObject);
        }
    }
}
