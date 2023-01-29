using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRotate : MonoBehaviour
{
    float orbitSpeed = 10;
    private Rigidbody2D boss;

    //Get the boss.
    void Awake(){
        boss = GameObject.Find("Boss").GetComponent<Rigidbody2D>();
    }

    // Rotate the shield around the boss.
    void Update()
    {
        transform.RotateAround (boss.transform.position, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}
