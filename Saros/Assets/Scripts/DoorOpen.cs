using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    //Color color;
    Rigidbody2D rb;
    Renderer cubeRenderer;
    int doorSpeed = 4;
    public bool DoorOpening = false;

    // Start is called before the first frame update
    void Start()
    {
        //color = gameObject.GetComponent<Color>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        cubeRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DoorOpening == true)
        {
            Debug.Log("Door opening");
            
            Vector2 movement = new Vector2();

            movement.x += 1;

            rb.velocity = movement * doorSpeed;

            cubeRenderer.material.SetColor("Color_", Color.red);
        }
    }
}
