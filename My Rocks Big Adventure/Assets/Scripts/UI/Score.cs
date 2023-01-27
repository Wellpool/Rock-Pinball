using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[Serializable]
public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text nameText;
    public float score = 0;
    public string name;
    public ScoreManager scoreManager;
    
    void Update()
    {
        //Update Score text every frame
        scoreText.text = "Score:" + score.ToString();
        StateNameController.sceneScore = score;
    }

    public Score(string name, float score){
        this.name = name;
        this.score = score;
    }

    public void SetName(){
        name = nameText.text;
        PlayerPrefs.SetString("name" , name);
        Debug.Log(PlayerPrefs.GetString(name));
    }

    public void AddScore(){
        scoreManager.AddScore(new Score(PlayerPrefs.GetString(name), StateNameController.sceneScore));
    }
}
