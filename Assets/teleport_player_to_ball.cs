using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_player_to_ball : MonoBehaviour
{
    public GameObject ball;
    public Vector3 old_position;
    public int samePositionCounter;
    public Vector3 lastValidPosition;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
        old_position = ball.transform.position;
        samePositionCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.Find("ball");

        if (Vector3.SqrMagnitude(ball.transform.position - old_position) < 0.000000001)
        {
            samePositionCounter++;

            if (samePositionCounter >= 100)
            {
                
                this.transform.position = new Vector3(ball.transform.position.x, this.transform.position.y, ball.transform.position.z);

                lastValidPosition = ball.transform.position;
                samePositionCounter = 0;
                Debug.Log("teleport");
            }
            
            
            
        }

        if (ball.transform.position.y < 0)
        {
            ball.transform.position = lastValidPosition;
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Debug.Log("ball reset");
            Debug.Log("transformposition:"+ ball.transform.position);
            Debug.Log("valid" + lastValidPosition);

        }

        old_position = ball.transform.position;
    }
}
