using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;


public class HoleTrigger : MonoBehaviour
{
    public int level;
    public GameObject onBoardingBoard;

    public SteamVR_Input_Sources LeftInputSource = SteamVR_Input_Sources.LeftHand;
    public SteamVR_Input_Sources RightInputSource = SteamVR_Input_Sources.RightHand;

    public bool gameFinished = false;


    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("lalala");
        if (level == 2)
            Physics.gravity = new Vector3(0, -1.6211f,0);
        else
            Physics.gravity = new Vector3(0, -9.81f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished == true && SteamVR_Actions._default.Squeeze.GetAxis(RightInputSource) == 1)
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT_anything");
        if (other.GetComponent<Collider>().gameObject.name == "ball")
        {
            Debug.Log("ball");
            if (level == 0)
            {
                SceneManager.LoadScene("level_desert_1", LoadSceneMode.Single);
                //level = 1;
            }
            if (level == 1)
            {
                SceneManager.LoadScene("level_moon", LoadSceneMode.Single);
                //level = 2;
            }

            if (level == 2)
            {
                onBoardingBoard.SetActive(true);
                gameFinished = true;
            }

        }
    }
}
