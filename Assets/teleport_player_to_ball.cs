using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_player_to_ball : MonoBehaviour
{
    public GameObject ball;
    public Vector3 old_position;

    // Start is called before the first frame update
    void Start()
    {
        old_position = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.SqrMagnitude(ball.transform.position - old_position) < 0.00000000000000001)
        {
            this.transform.position = new Vector3(ball.transform.position.x, this.transform.position.y, ball.transform.position.z) ;
        }
        old_position = ball.transform.position;
    }
}
