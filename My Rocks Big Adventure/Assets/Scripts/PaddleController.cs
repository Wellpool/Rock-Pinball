using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PaddleController : MonoBehaviour
{
    public bool RightPaddle;

    public UnityEvent PaddleSoundRight;
    public UnityEvent PaddleSoundLeft;
    
    //Simple script to use the motor on each paddle based on which key is pressed.
    void Update(){
        if((RightPaddle && (Input.GetAxis("Horizontal") > 0)) || (!RightPaddle && (Input.GetAxis("Horizontal") < 0))){
            GetComponent<HingeJoint2D>().useMotor = true;
            
            
        }
        else{
            GetComponent<HingeJoint2D>().useMotor = false;
        }
        
        if(Input.GetKeyDown("d"))
        {
            PaddleSoundRight.Invoke();
        }
        
        if(Input.GetKeyDown("a"))
        {
            PaddleSoundLeft.Invoke();
        }
        
    }
}
