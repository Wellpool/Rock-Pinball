using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class LivesKill : MonoBehaviour
{
private int Lives = 3;
public Text loseText;
public Text lifeText;
public Rigidbody2D Player;
public GameObject Spawn;

public UnityEvent respawnSound;


//Setting the initial values of the texts.
void Start(){
   loseText.text = "";
   lifeText.text = "Lives:" + Lives;
   GetComponent<AudioSource>();
}

//Taking away from the life counter if the player dies and updating the text accordingly.
   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.CompareTag("Player")){
      if(Lives == 1){
         Time.timeScale = 0;
         loseText.text = "Game Over!";
      }
      else{
         Lives--;
         Player.transform.position = Spawn.transform.position;
         lifeText.text = "Lives:" + Lives;
         respawnSound.Invoke();
      }
      }    
      }
   } 


