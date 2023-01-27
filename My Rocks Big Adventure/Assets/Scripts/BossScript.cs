using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    private int health = 100;
    private bool active = true;
    private int shotsFired = 0;
    private int timer = 750;
    private float bulletSpeed = 15;
    
    private Rigidbody2D rb; 
    private Transform bulletSpawnPoint;
    public GameObject bulletPrefab;

    //Find the player and the bullet spawn point.
    void Start()
    {
        rb = GameObject.Find("Rock").GetComponent<Rigidbody2D>();
        bulletSpawnPoint = GameObject.Find("BulletSpawnPoint").GetComponent<Transform>();
    }
    
    //If the boss is active start checking the timer and decreasing it.
    void Update()
    { 
        if(active == true){
        ShootTimer();
        }
        if(health == 0){
            Destroy(gameObject);
        }
    }

    void FixedUpdate(){
        if(active == true){
        timer -= 1;
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
            timer = 750;
        }
        else if(timer == 0 && shotsFired == 3){
            Shoot();
            Invoke("Shoot", 1);
            Invoke("Shoot", 2);
            shotsFired = 0;
            timer = 750;
        }
    }
    
    //Create and shoot the bullet.
    private void Shoot(){
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = rb.position * bulletSpeed;
    }
}
