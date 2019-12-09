using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_player_to_ball : MonoBehaviour
{
    public GameObject ball;
    public Vector3 old_position;
    public int samePositionCounter;

    // Start is called before the first frame update
    void Start()
    {
        old_position = ball.transform.position;
        samePositionCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.SqrMagnitude(ball.transform.position - old_position) < 0.000000000000000001)
        {
            samePositionCounter++;

            if (samePositionCounter >= 100)
            {
                this.transform.position = new Vector3(ball.transform.position.x, this.transform.position.y, ball.transform.position.z);
                samePositionCounter = 0;
                Debug.Log("teleport");
            }
            

            
        }
        old_position = ball.transform.position;
    }
}
