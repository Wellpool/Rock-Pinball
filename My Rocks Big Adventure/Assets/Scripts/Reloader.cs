using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("r")) 
        {
            Restart();
        }
    }
 
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
 