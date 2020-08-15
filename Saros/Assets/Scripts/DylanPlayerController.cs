using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DylanPlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2();

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x -= 1;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            movement.x += 1;
        }

        rb.velocity = speed * movement;
    }
}
