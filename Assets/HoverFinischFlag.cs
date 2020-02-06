using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverFinischFlag : MonoBehaviour
{

    //adjust this to change speed
    public float speed = 5f;
    //adjust this to change how high it goes
    public float height = 0.5f;
    public float originHeight;


    // Start is called before the first frame update
    void Start()
    {
        //originHeight = this.transform.position.y;
    }

    
    void Update()
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = this.transform.parent.transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        newY += originHeight;
        Debug.Log("Y = " + newY);
        Debug.Log("x = " + pos.x);
        Debug.Log("z = " + pos.z);

        //set the object's Y to the new calculated Y
        this.transform.position = new Vector3(pos.x + this.transform.position.x, newY, pos.z + this.transform.position.z) * height;
    }
}
