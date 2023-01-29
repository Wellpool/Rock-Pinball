using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Rigidbody2D rb;
    public int addPoint = 10;
    public Score score;
    
    //Get the objects.
    void Awake(){
        rb = GameObject.Find("Rock").GetComponent<Rigidbody2D>();
        score = GameObject.Find("UI").GetComponent<Score>();
    }
    
    //Add force to the player when they go through the spinner.
    void OnTriggerEnter2D(Collider2D collider){
        rb.AddForce(new Vector2(600f,-100f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If Rock collides Adds "x" to score
        if (collision.gameObject.CompareTag("Player"))
        {
            score.score += addPoint;
        }
    }
}
