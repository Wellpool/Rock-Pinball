using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;
 
    void Update()
    {
        //Update Score text every frame
        scoreText.text = "Score:" + score.ToString();
    }
}
