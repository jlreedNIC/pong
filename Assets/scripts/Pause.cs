/***************************************************
* Id: reed5204
*
* File: Pause.cs
* Class: CS 383
*
* This class controls the pause screen.
****************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isGamePaused = false;
    private GameObject pauseScreen;
    private GameObject pauseBackground;

    // Start is called before the first frame update
    // Initialize the game objects and set them to not active
    void Start()
    {
        pauseScreen = GameObject.Find("Canvas");
        pauseBackground = GameObject.Find("PauseBackground");
        pauseScreen.SetActive(false);
        pauseBackground.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if pause button pressed
        if(Input.GetKeyDown("space"))
        {
            PauseGame();            
        }        
    }

    // When game is paused, stop time and activate the pause screens.
    // When game is unpaused, start time back up, and deactivate pause screens.
    void PauseGame()
    {
        isGamePaused = !isGamePaused;
        
        if(isGamePaused)
        {
            pauseScreen.SetActive(true);
            pauseBackground.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pauseScreen.SetActive(false);
            pauseBackground.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
