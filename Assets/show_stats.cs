using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_stats : MonoBehaviour
{
    public GameObject box;
    Text stats;

    void Start()
    {
        stats = GetComponent<Text>();
        stats.text = "Hello";

       // PlayerScript playerScript = thePlayer.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        stats.text = "Count: " + box.GetComponent<ball_force>().hit_counter;
    }
}
