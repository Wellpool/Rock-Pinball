using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class RockDash : MonoBehaviour
{

Vector3 mousePosition;
Vector3 direction;
Rigidbody2D rb2d;
public Text cdText;

bool onCooldown = false;
int dashTimer = 0;
public int seconds = 12; //We can set how many seconds the cooldown is using this variable.
public float moveSpeed;

public UnityEvent DashSound;

void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //Gets the Rock's Rigid Body.
    }

//If the mouse button is clicked and the dash isn't on cooldown we dash the rock in the direction of the mouse with a set speed.
void Update()
    {
        if (Input.GetMouseButton(0) && onCooldown == false)
        {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb2d.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        onCooldown = true; //Once the dash is used it is set on cooldown.
        dashTimer = 50 * seconds; //We start a timer to determine it's cooldown.
        dashTimer--;
        DashSound.Invoke();
        }
    }

//Once the dash cooldown reaches 0 we set the cooldown boolean to false so that the player can dash again.
void FixedUpdate()
    {
        cdText.text = "Dash Cooldown: " + (dashTimer/50 + 1) + "s";
        
        if(dashTimer < 50 * seconds && dashTimer != 0)
        {
            dashTimer--; //if the dash is on cooldown we take away from it every 50 times a second.
        }
        if(dashTimer == 0)
        {
            onCooldown = false; //Dash cooldown is finished and boolean is reset so we can dash again.
            cdText.text = "Dash Ready";
        }
    }
}
