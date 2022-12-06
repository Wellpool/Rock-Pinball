using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public bool RightPaddle;
    //Simple script to use the motor on each paddle based on which key is pressed.
    void Update(){
        if((RightPaddle && (Input.GetAxis("Horizontal") > 0)) || (!RightPaddle && (Input.GetAxis("Horizontal") < 0))){
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else{
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}
