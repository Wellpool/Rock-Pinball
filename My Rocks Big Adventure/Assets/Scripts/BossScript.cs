using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    private int health = 100;
    private bool active = false;
    private int shotsFired = 0;
    private int timerAmount = 750;
    private int timer;
    private Rigidbody2D rightBound;
    private Rigidbody2D leftBound;
    private Rigidbody2D rb;
    private Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public Button button;
    public Score score;

    //Find the player and the bullet spawn point.
    void Start()
    {
        timer = timerAmount;
        rb = GetComponent<Rigidbody2D>();
        score = GameObject.Find("UI").GetComponent<Score>();
        rightBound = GameObject.Find("BossBoundr").GetComponent<Rigidbody2D>();
        leftBound = GameObject.Find("BossBoundl").GetComponent<Rigidbody2D>();
        bulletSpawnPoint = GameObject.Find("BulletSpawnPoint").GetComponent<Transform>();
        rb.velocity = new Vector2(10,0);
        gameObject.SetActive(false);
    }
    
    //If the boss is active start checking the timer and decreasing it.
    void Update()
    { 
        if(button.pressed == 3){
            active = true;
        }
        if(active == true){
        ShootTimer();
        }
        if(health == 0){
            score.score =+ 100;
            Destroy(gameObject);
        }
    }

    void FixedUpdate(){
        if(active == true){
        timer -= 1;
        }
        if(rb.position.x > rightBound.position.x){
           rb.velocity = new Vector2(-10,0);
        }
        else if(rb.position.x < leftBound.position.x){
           rb.velocity = new Vector2(10,0);
        }
    }
    
    //If the boss collides with the player take away its health.
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
        health -= 20;
        }
    }
    
    //If the timer reaches 0, shoot and reset it.
    private void ShootTimer(){
        if(timer == 0 && shotsFired < 3){
            Shoot();
            shotsFired++;
        }
        else if(timer == 0 && shotsFired == 3){
            Shoot();
            Invoke("Shoot", 1);
            Invoke("Shoot", 2);
            shotsFired = 0;
        }
    }
    
    //Create and shoot the bullet.
    private void Shoot(){
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        timer = timerAmount;
    }
}
