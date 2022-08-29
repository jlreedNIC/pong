using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isGamePaused = false;
    private GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreen = GameObject.Find("Canvas");
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            PauseGame();            
        }        
    }

    void PauseGame()
    {
        isGamePaused = !isGamePaused;
        
        if(isGamePaused)
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
