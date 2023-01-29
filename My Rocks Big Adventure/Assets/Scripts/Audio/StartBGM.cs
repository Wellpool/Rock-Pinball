using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartBGM : MonoBehaviour
{
    public UnityEvent mainBGM;
    // Start is called before the first frame update
    void Start()
    {
        mainBGM.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
