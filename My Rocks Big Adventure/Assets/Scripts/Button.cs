using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public BossScript boss;
    
    //Get the boss.
    void Awake(){
        boss = GameObject.Find("Boss").GetComponent<BossScript>();
    }
    
    //If 3 buttons have been pressed summon the boss.
    void Update(){
        if(boss.pressed == 3){
            boss.Activated();
        }
    }

    //If the button is collided with, destroy it and increment the counter.
    void OnCollisionEnter2D(Collision2D collision){
        boss.pressed++;
        Destroy(gameObject);
        Debug.Log(boss.pressed);
    }
}
