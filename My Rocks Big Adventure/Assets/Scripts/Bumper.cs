using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public int addPoint = 10;

    //Get Rock Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If Rock collides Adds "x" to score
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log ("Hit!!");
            Score.score += addPoint;
            Debug.Log (Score.score);
        }
    }
}
