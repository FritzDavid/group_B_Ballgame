using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; 

public class GameStart : MonoBehaviour
{
    public GameObject ball;
    public GameObject onBoardingBoard;
    private float ballYPos = 0;
    private bool gamestarted = false;
    public SteamVR_Input_Sources LeftInputSource = SteamVR_Input_Sources.LeftHand;
    public SteamVR_Input_Sources RightInputSource = SteamVR_Input_Sources.RightHand;

    // Start is called before the first frame update
    void Start()
    {
        ballYPos = ball.transform.position.y;
        ball.transform.position = new Vector3(ball.transform.position.x, -1 , ball.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (gamestarted == false && SteamVR_Actions._default.Squeeze.GetAxis(RightInputSource) == 1)
        {
            ball.transform.position = new Vector3(ball.transform.position.x, ballYPos, ball.transform.position.z);
            onBoardingBoard.SetActive(false);
            Debug.Log("Right Trigger value:" + SteamVR_Actions._default.Squeeze.GetAxis(RightInputSource).ToString());
            gamestarted = true;
        }
    }

}
