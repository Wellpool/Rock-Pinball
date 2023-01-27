using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Score Score;
    void OnCollisionEnter2D(Collision2D collision){
        //Ignore Collision with the boss.
        if(collision.gameObject.CompareTag("Boss")){
        }
        //If we collide with the player and their score is over 10 take 10 points away.
        else if(collision.gameObject.CompareTag("Player") && Score.score > 10){
        Score.score -= 10;
        Destroy(gameObject);
        }
        //If we collide with the player and their score is under 10 set it to 0 to avoid negatives.
        else if(collision.gameObject.CompareTag("Player") && Score.score < 10){
        Score.score = 0;
        Destroy(gameObject);
        }
        //If we collide with anything else destroy the bullet.
        else{
        Destroy(gameObject);
        }
    }
}
