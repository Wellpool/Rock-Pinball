using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 

public class CameraLock : MonoBehaviour 
{ 
    private Quaternion lockedRotation; 
    public Transform followTransform;
    public BoxCollider2D mapBounds;

    private float xMin, xMax, yMin, yMax;
    private float camY,camX;
    private float camOrthsize;
    private float cameraRatio;
    private Camera mainCam;

    //Lock the camera from rotating and set the bounds of the camera so it can't go beyond the map.
    void Start() 
    { 
       lockedRotation = transform.rotation;
       xMin = mapBounds.bounds.min.x;
       xMax = mapBounds.bounds.max.x;
       yMin = mapBounds.bounds.min.y;
       yMax = mapBounds.bounds.max.y;
       mainCam = GetComponent<Camera>();
       camOrthsize = mainCam.orthographicSize;
       cameraRatio = (xMax + camOrthsize) / 3f; 
    } 
    
    //Fix the camera positioning if it is going out of
    void FixedUpdate() 
    { 
        camY = Mathf.Clamp(followTransform.position.y, yMin + camOrthsize, yMax - camOrthsize);
        camX = Mathf.Clamp(followTransform.position.x, xMin + cameraRatio, xMax - cameraRatio);
        this.transform.position = new Vector3(camX, camY, this.transform.position.z);
    } 

    void Update(){
        transform.rotation = lockedRotation; //Stops the Camera from rotating.
    }
} 

 
 

 