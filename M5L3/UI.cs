/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program handles the operation of UI, 
 *      specifically, the update on the player's
 *      points as well as the display of the defeat 
 *      window.
 * 
 * How to use the script:
 *      - Add the ready-made Space Shooter UI object
 *      - Attach the script to the Player
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;                        // library needed to work with text
using UnityEngine.SceneManagement;  // library needed for working with the scene

public class UI : MonoBehaviour
{
    // links to other game objects, assignable via the Inspector window
    public Player player;                       // link to the Player component of the player
    public TextMeshProUGUI pointsText;          // link to the TextMeshProGUI component of the score
    public GameObject defeatUI;                 // link to all UI elements of the defeat window

    // disabling the defeat window to hide it at the beginning of the game
    void Start()
    {
        defeatUI.SetActive(false);
    }

    // continuously update points and continuously check if the Player is still in the scene
    void Update()
    {
        // updating the text with the number of items collected
        // ToString() method converts a numeric data type to string
        pointsText.text = player.points.ToString();

        // if the Player goes out of the scene (that is, if the Player is destroyed, which makes it null),
        // show the defeat UI
        if (player == null)
        {
            defeatUI.SetActive(true);
        }
    }

    // when the restart button of the defeat window is clicked, restart the scene
    public void OnClickRestart()
    {
        // getting the index of the current scene and restarting it
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
