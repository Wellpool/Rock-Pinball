using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class LivesKill : MonoBehaviour
{
private int Lives = 1;
public bool gameOver = false;
public Text loseText;
public Text lifeText;
public Rigidbody2D Player;
public GameObject Spawn;
public GameObject nameField;

public UnityEvent respawnSound;


//Setting the initial values of the texts.
void Start(){
   loseText.text = "";
   lifeText.text = "Lives:" + Lives;
   GetComponent<AudioSource>();
   nameField.SetActive(false);
}

//Taking away from the life counter if the player dies and updating the text accordingly.
   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.CompareTag("Player")){
      if(Lives == 1){
         Time.timeScale = 0;
         loseText.text = "Game Over!";
         nameField.SetActive(true);
         gameOver = true;
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


