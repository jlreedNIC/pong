/***************************************************
* Id: reed5204
*
* File: PlayerControls.cs
* Class: CS 383
*
* This class controls the pong paddles.
****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;

    [Range(1,10)]
    public float speed = 10.0f;             // speed of paddles
    public float boundY = 2.25f;            // paddles cannot move past the boundaries
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if game is paused to avoid input complications
        if(!Pause.isGamePaused)
        {
            // moving paddles up and down
            var vel = rb2d.velocity;
            if(Input.GetKey(moveUp))
            {
                vel.y = speed;
            }
            else if(Input.GetKey(moveDown))
            {
                vel.y = -speed;
            }
            else
            {
                vel.y = 0;
            }
            rb2d.velocity = vel;

            // setting bounds on position
            var pos = transform.position;
            if(pos.y > boundY)
            {
                pos.y = boundY;
            }
            else if(pos.y < -boundY)
            {
                pos.y = -boundY;
            }
            transform.position = pos;
        }
        
    }
}
