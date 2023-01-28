using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Score Score;
    Vector2 bulletDirection;
    private float bulletSpeed = 30;
    private Rigidbody2D player; 
    private Rigidbody2D bullet;

    void Awake(){
        player = GameObject.Find("Rock").GetComponent<Rigidbody2D>();
        bullet = GetComponent<Rigidbody2D>();
        Score = GameObject.Find("UI").GetComponent<Score>();
    }

    void Start(){
        bulletDirection = (player.transform.position - transform.position).normalized * bulletSpeed;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletDirection.x, bulletDirection.y);
    }

    void OnTriggerEnter2D(Collider2D other){
        //If we collide with the player and their score is over 10 take 10 points away.
        if(other.CompareTag("Player") && Score.score >= 10){
        Score.score -= 10;
        Destroy(gameObject);
        }
        //If we collide with the player and their score is under 10 set it to 0 to avoid negatives.
        else if(other.CompareTag("Player") && Score.score < 10){
        Score.score = 0;
        Destroy(gameObject);
        }
        //If we collide with anything else destroy the bullet.
        if(other.CompareTag("Environment")){
        Destroy(gameObject);
        }
    }
}
