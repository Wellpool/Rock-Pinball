using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public int addPoint = 300;
    public Score score;

    void Awake(){
        score = GameObject.Find("UI").GetComponent<Score>();
    }
    
    //Get Rock Collision
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //If Rock collides Adds "x" to score
        if (collider.gameObject.CompareTag("Player"))
        {
            score.score += addPoint;
        }
    }
}
