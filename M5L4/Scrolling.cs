/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements a scrolling background
 *      especially for the racing level of the 2D
 *      shooter game.
 * 
 * How to use the script:
 *      - Attach the script to the Road object of the 
 *          racing level.
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{ 
    public float speed;             // scrolling speed of the road

    [SerializeField]
    private Renderer bgRenderer;    // holds the Mesh Renderer component of the road

    // continuously vertically scroll the road so that the car player appears to be moving 
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
        // note: if the arguments are swapped, the road would instead move horizontally
    }
}
