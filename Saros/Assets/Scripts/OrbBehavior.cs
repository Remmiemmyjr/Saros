using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D otherRb;
    Vector3 distance;
    bool happened;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        otherRb = other.GetComponent<Rigidbody2D>();

        //other.transform.position = transform.position;
        Debug.Log("Triggered");
        if(CosmoController.homeOrb != (object)this)
        {
            StartCoroutine(ToOrb(other));
        }

    }

    IEnumerator ToOrb(Collider2D other)
    {
        otherRb.bodyType = RigidbodyType2D.Static;

        distance = other.transform.position - transform.position;
        
        while (distance.magnitude > 0.1)
        {
            otherRb.velocity = Vector3.zero;
            other.transform.position = Vector3.MoveTowards(other.transform.position, transform.position, 0.2f);
            yield return new WaitForSeconds(0.01f);
            distance = other.transform.position - transform.position;
        }

        CosmoController.homeOrb = this;
        CosmoController.anchor = this.gameObject.transform.position;
    }
}
