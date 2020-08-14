using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CosmoController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 velocity;
    Vector3 direction;
    Vector3 startMousePos;
    Vector3 currentMousePos;
    Vector3 anchor;

    public float maxDistance = 3;
    public float speed = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anchor = transform.position;
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

    private void OnMouseDown()
    {
        startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = currentMousePos - startMousePos;
        if(direction.magnitude > maxDistance)
        {
            direction = direction.normalized * maxDistance;
        }
        transform.position = anchor + direction;

        Debug.Log(direction);
    }

    private void OnMouseUp()
    {
        //transform.position = anchor;

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.AddForce(-direction * 5f, ForceMode2D.Impulse);
    }
}
