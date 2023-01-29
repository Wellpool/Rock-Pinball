using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUi;
    public GameObject shopeMenuUi;
    public GameObject gameUi;

    private void Start()
    {
        //This to make sure the panel does not show on start
        pauseMenuUi.SetActive(false);
        shopeMenuUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Escape to pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }
    
    //This hides the pause menu and resumes game
    void Resume()
    {
        pauseMenuUi.SetActive(false);
        shopeMenuUi.SetActive(false);
        shopeMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //This opens the pause menu panel and pauses the game
    void PauseGame()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    //Open Shop
    public void OpenShop()
    {
        pauseMenuUi.SetActive(false);
        shopeMenuUi.SetActive(true);
    }
    
    //Back Out of shop
    public void CloseShop()
    {
        pauseMenuUi.SetActive(true);
        shopeMenuUi.SetActive(false);
    }
    
    //Exit game from pause menu
    public void ExitGameFromPause()
    {
        Application.Quit();
    }
}