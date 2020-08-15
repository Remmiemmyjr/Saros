using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    Rigidbody2D rb;
    Transform transform;
    int doorSpeed = 4;
    public bool DoorOpening = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DoorOpening == true)
        {
            Debug.Log("Door opening");
            rb.AddForce(transform.forward * doorSpeed);
        }
    }
}
