using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Final Scene");
    }
    
    public void Quit(){
        Application.Quit();
    }

    public void Scoreboard(){
        SceneManager.LoadScene("Scoreboard");
    }

    public void Menu(){
        SceneManager.LoadScene("UIStartScreen");
    }
}
