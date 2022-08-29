/***************************************************
* Id: reed5204
*
* File: SideWalls.cs
* Class: CS 383
*
* This class controls the scoring functions of the walls.
****************************************************/

using System.Collections;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when the wall is hit with the ball, give points and restart the ball
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
