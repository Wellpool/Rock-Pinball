using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int pressed = 0;

    void OnCollisionEnter2D(Collision2D collision){
        pressed++;
        Destroy(gameObject);
    }
}
