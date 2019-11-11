using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfclub : MonoBehaviour
{

    public Vector3 pos;
    public Vector3 rot;
   public GameObject golfclub_object;
   public Quaternion q;
    // Start is called before the first frame update
    void Start()
    {

        //Position werte:
        // position: X:-0.018   Y:: -0.034      Z: 0.239
        pos.x = -0.05f;
        pos.y = 0.07f;
        pos.z = 0.2f;

        rot.x = -70.0f;
        rot.y = 30.0f;
        rot.z = 0.0f;
        Debug.Log("ratoation: " + Quaternion.Angle(golfclub_object.transform.rotation, this.transform.rotation));
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 positionVektor = new Vector3(this.transform.position.x + pos.x, this.transform.position.y + pos.y, this.transform.position.z + pos.z);
        Vector3 rotationVector;

       



        // generate a random euler angle
        rotationVector.x = this.transform.rotation.x;
        rotationVector.y = this.transform.rotation.y;
        rotationVector.z = this.transform.rotation.z;


        // convert the euler into a quaternion
        q = Quaternion.Euler(rotationVector);

   

        golfclub_object.transform.position = positionVektor;

		golfclub_object.transform.rotation = this.transform.rotation;
        golfclub_object.transform.Rotate(new Vector3(rot.x, rot.y, rot.z)); 
        
        

        Debug.Log("rotationVector.x: " + rotationVector.x +  "rotationVector.y: " + rotationVector.y +  "rotationVector.z: " + rotationVector.z);


    }
}
