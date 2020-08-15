using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Button : MonoBehaviour
{
    public DoorOpen doorOpenScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()
    {
        UnityEngine.Debug.Log("Button clicked");
        doorOpenScript.DoorOpening = true;
    }
}
