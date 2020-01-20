using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT_anything");
        if (other.GetComponent<Collider>().gameObject.name == "ball")
        {
            Debug.Log("ball");
            SceneManager.LoadScene("level_moon_1", LoadSceneMode.Single);
        }
    }
}
