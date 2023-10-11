/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program handles the operation of the 
 *      main menu (that is, whether to start the 
 *      game when the Start button is pressed, or
 *      to stop the game when the Exit button is 
 *      pressed).
 * 
 * How to use the script:
 *      - Attach the script to the MainMenu object
 *          under the UI object
 *      - Setup in the Inspector the method to be 
 *          executed when the buttons are pressed
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // library to be able to manage the scene

public class MainMenu : MonoBehaviour
{
    // name of the scene to be loaded when the Start button is clicked
    // can be set via the Inspector window
    public string sceneName;

    // when the Start button is clicked, load the specified scene
    public void OnClickStart()
    {
        SceneManager.LoadScene(sceneName);
    }

    // when the Exit button is clicked, stop the game
    public void OnClickExit()
    {
        Application.Quit();
        print("Exit was clicked");  // printing a text for debugging purposes
    }
}
