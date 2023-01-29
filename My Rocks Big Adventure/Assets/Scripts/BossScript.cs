using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript : MonoBehaviour
{
    private int health = 100;
    private bool active = false;
    private int shotsFired = 0;
    private int timerAmount = 750;
    private int timer;
    public int pressed = 0;
    private Text bossText;
    private Rigidbody2D rightBound;
    private Rigidbody2D leftBound;
    private Rigidbody2D rb;
    private Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public Button button;
    public Score score;

    //Finding all the required objects to make the script work and disabling the boss initially.
    void Start()
    {
        timer = timerAmount;
        rb = GetComponent<Rigidbody2D>();
        bossText = GameObject.Find("BossText").GetComponent<Text>();
        score = GameObject.Find("UI").GetComponent<Score>();
        rightBound = GameObject.Find("BossBoundr").GetComponent<Rigidbody2D>();
        leftBound = GameObject.Find("BossBoundl").GetComponent<Rigidbody2D>();
        bulletSpawnPoint = GameObject.Find("BulletSpawnPoint").GetComponent<Transform>();
        gameObject.SetActive(false);
    }
    
    //If the boss is active start checking the timer and decreasing it.
    //If the boss dies destroy it and give the player score.
    void Update()
    { 
        if(active == true){
        ShootTimer();
        }
        if(health == 0){
            score.score =+ 3500;
            Destroy(gameObject);
            bossText.text = "";
        }
    }

    //Decrease the timer and make the boss move within boundaries.
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
    
    //Function to activate the boss, get it moving and increment the button count so it doesn't keep getting called.
    public void Activated(){
        active = true;
        gameObject.SetActive(true);
        rb.velocity = new Vector2(10,0);
        bossText.text = "Boss Has Been Summoned!";
        pressed++;
    }

    //If the boss collides with the player take away its health.
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
        health -= 20;
        }
    }
    
    //If the timer reaches 0, shoot and reset it. After 3 times shoot 3 bullets instead of 1.
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
