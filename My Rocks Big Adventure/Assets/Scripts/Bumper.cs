using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public int addpoint = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Get Rock Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If Rock collides Adds "x" to score
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log ("Hit!!");
            Score.score += addpoint;
            Debug.Log (Score.score);
        }
    }


    // Update is called once per frame
    void Update()
    {
                        
    }

}
