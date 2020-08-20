using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CosmoController : MonoBehaviour
{
    internal static object homeOrb;

    Rigidbody2D rb;
    Vector2 velocity;
    Vector3 direction;
    Vector3 startMousePos;
    Vector3 currentMousePos;
    internal static Vector3 anchor;

    public float maxDistance = 3;
    public float speed = 4f;
    public float forceMultiplier = 50f;

    void Start()
    {
        object s = this.gameObject;

        rb = GetComponent<Rigidbody2D>();
        anchor = transform.position;

        Time.timeScale = 2;
    }

    void Update()
    {
    //    velocity = rb.velocity;
    //    if(Input.GetKey(KeyCode.RightArrow))
    //    {
    //        velocity.x = speed;
    //    }
    //    else if(Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        velocity.x = -speed;
    //    }
    //    else
    //    {
    //        velocity.x = 0;
    //    }
    //    rb.velocity = velocity;

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    private void OnMouseDown()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
        startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = currentMousePos - startMousePos;
        direction = direction.normalized * Mathf.Sqrt(direction.magnitude);
        if (direction.magnitude > maxDistance)
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
        rb.AddForce(-direction * forceMultiplier, ForceMode2D.Impulse);
        //rb.velocity = -direction * forceMultiplier;

        Debug.Log($"Mouse Up: {-direction * forceMultiplier} RB Vel: {rb.velocity}");
    }
}
