using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBall : MonoBehaviour
{
    
    public Vector3 velocity;
    public Rigidbody rb;
   


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude <= 0.13)
        {
            rb.velocity = new Vector3(0, 0, 0);
        } 
    }
}
