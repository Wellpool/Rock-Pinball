using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Rigidbody2D rb;
    
    void Update()
    {
         
        this.transform.position = new Vector3(rb.transform.position.x,rb.transform.position.y,-57);
    }
}
