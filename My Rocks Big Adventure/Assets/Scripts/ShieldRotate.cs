using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRotate : MonoBehaviour
{
    float shieldRotateSpeed = -25;
    float orbitSpeed = 10;
    private Rigidbody2D boss;

    void Awake(){
        boss = GameObject.Find("Boss").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround (boss.transform.position, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}
