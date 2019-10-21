using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfclub : MonoBehaviour
{
   public GameObject golfclub_object; 

   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        golfclub_object.transform.position = this.transform.position;
		golfclub_object.transform.rotation = this.transform.rotation;
    }
}
