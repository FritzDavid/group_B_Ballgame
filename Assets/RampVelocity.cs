using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampVelocity : MonoBehaviour
{

    public Vector3 velocityOld;
    public Vector3 velocity;
    public float faktor = 1.5f;
    public GameObject ball;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ball = GameObject.Find("ball");
        velocityOld = ball.GetComponent<Rigidbody>().velocity;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ball")
        {
            Debug.Log("velocity ball");
            velocity = new Vector3(velocityOld.x * faktor, velocityOld.y * faktor, velocityOld.z * faktor);
            other.attachedRigidbody.velocity = velocity;
        }

    }
}
