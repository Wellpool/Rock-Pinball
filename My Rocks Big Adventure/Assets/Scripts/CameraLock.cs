using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 

public class CameraLock : MonoBehaviour 
{ 
    private Quaternion lockedRotation; 

    void Start() 
    { 
       lockedRotation = transform.rotation; 
    } 

    void Update() 
    { 
        transform.rotation = lockedRotation; //Stops the Camera from rotating.
    } 
} 

 
 

 