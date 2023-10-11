/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program simply prevents the music player
 *      and background objects in the main menu from 
 *      being destroyed when the Start or Restart 
 *      buttons are clicked.
 * 
 * How to use the script:
 *      - Attach the script to both MusicPlayer and
 *          Background objects in the main menu
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // when the game starts, prevent the music player and background objects from being destroyed
    // note that this script is attached to the music player and background objects
    // thus, this.gameObject refers to those objects
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
