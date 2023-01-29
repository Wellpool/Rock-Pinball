using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bumper : MonoBehaviour
{
    public int addPoint = 250;
    public Score score;

    public UnityEvent bumperSound;

    void Awake()
    {
        score = GameObject.Find("UI").GetComponent<Score>();
    }
    
    //Get Rock Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If Rock collides Adds "x" to score
        if (collision.gameObject.CompareTag("Player"))
        {
            score.score += addPoint;
            bumperSound.Invoke();
        }
    }
}
