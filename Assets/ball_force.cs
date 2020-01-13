using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_force : MonoBehaviour
{
    public Vector3 old_position;
    public Vector3 delta_position;
    public Vector3 velocity;
    public float t; //Zeit
    public int hit_counter;


    // Start is called before the first frame update
    void Start()
    {
        old_position = this.transform.position;
        hit_counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.deltaTime;

        delta_position = this.transform.position - old_position;
        velocity = delta_position / t;


       

        old_position = this.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ball")
        {
            other.attachedRigidbody.velocity = velocity;
            hit_counter++;
        }
        
    }
}
