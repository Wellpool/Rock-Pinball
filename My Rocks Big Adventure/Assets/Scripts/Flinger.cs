using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flinger : MonoBehaviour
{
    float power;
    public float maxPower = 100f;
    public Slider powerSlider;
    public Rigidbody2D rb;
    bool _ballSpawn = false;

    //We setup the variables for the slider and set its default state to inactive.
    void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        powerSlider.gameObject.SetActive(false);
    }

    //This is where we launch the ball if the user presses Space.
    void Update()
    {
        if(_ballSpawn == true){
        powerSlider.value = power;
        if(Input.GetKey(KeyCode.Space)){
            if(power<=maxPower){
                power+=50*Time.deltaTime;
            }
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            rb.AddForce(power*Vector2.up*50);
            power = 0f;
        }
        }
    }

    //When the ball is in spawn the slider is active and the ball can be launched.
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            _ballSpawn = true;
            powerSlider.gameObject.SetActive(true);
        }
    }

    //When the ball leaves spawn we hide the slider and the ball can no longer be launched until it returns.
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            _ballSpawn = false;
            powerSlider.gameObject.SetActive(false);
        }
    }
}
