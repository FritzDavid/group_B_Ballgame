using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResults : MonoBehaviour
{
    public GameObject box;
    public GameObject camera;
    public GameObject controller;
    public GameObject club_blue;
    public GameObject cube;

    Text stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<Text>();
        stats.text = "Hello";
    }

    // Update is called once per frame
    void Update()
    {

        int valueFromPreviousScene = GameObject.FindGameObjectWithTag("ClubCollider").GetComponent<ball_force>().hit_counter;
        //camera = GameObject.Find("[Camera Rig]");
        //controller = camera.transform.Find("Controller(right)").gameObject;
        //club_blue = controller.transform.Find("club_blue").gameObject;
        //cube = club_blue.transform.Find("Cube").gameObject;

        //stats.text = "Result hits: " + cube.GetComponent<ball_force>().hit_counter;

        stats.text = "Result hits: " + valueFromPreviousScene;

        Debug.Log("Result hits: " + valueFromPreviousScene);
    }
}
