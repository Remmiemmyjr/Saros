using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmoController : MonoBehaviour
{
    
    public AnimationCurve curve;
    Rigidbody2D rb;
    Vector3 anchor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anchor = transform.position;
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {

    }

    private void OnMouseDrag()
    {
        
    }

    private void OnMouseUp()
    {
        
    }
}
