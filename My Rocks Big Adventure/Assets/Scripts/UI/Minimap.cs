using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Rigidbody2D rb;
    
    //Move the star to the position of the player.
    void Update()
    {
        this.transform.position = new Vector3(rb.transform.position.x,rb.transform.position.y,-57);
    }
}
