using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmoController : MonoBehaviour
{
    public float speed = 4f;
    Vector2 velocity;
    //public AnimationCurve curve;
    Rigidbody2D rb;
    //Vector3 anchor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anchor = transform.position;
    }

    void Update()
    {
        velocity = rb.velocity;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = speed;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -speed;
        }
        else
        {
            velocity.x = 0;
        }
        rb.velocity = velocity;
        
    }

    //private void OnMouseDown()
    //{

    //}

    //private void OnMouseDrag()
    //{
        
    //}

    //private void OnMouseUp()
    //{
        
    //}
}
