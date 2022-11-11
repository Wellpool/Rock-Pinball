using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public bool RightPaddle;

    void Update(){
        if((RightPaddle && Input.GetKey(KeyCode.A)) || (!RightPaddle && Input.GetKey(KeyCode.D))){
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else{
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}
