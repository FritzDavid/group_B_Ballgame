using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class accelerate_arrows : MonoBehaviour
{
    public bool isImgOn;
    public bool isImgOn2;
    public bool isImgOn3;
    public RawImage img;
    public RawImage img2;
    public RawImage img3;

    void Start()
    {
        InvokeRepeating("TriggerImage", 1.0f, 0.6f);
        InvokeRepeating("TriggerImage2", 1.1f, 0.6f);
        InvokeRepeating("TriggerImage3", 1.2f, 0.6f);
    }

    void TriggerImage()
    {
        if (isImgOn == true)
        {

            img.enabled = false;
            isImgOn = false;
        }

        else
        {

            img.enabled = true;
            isImgOn = true;
        }

    }
    void TriggerImage2()
    {
        if (isImgOn2 == true)
        {

            img2.enabled = false;
            isImgOn2 = false;
        }

        else
        {

            img2.enabled = true;
            isImgOn2 = true;
        }

    }
    void TriggerImage3()
    {
        if (isImgOn3 == true)
        {

            img3.enabled = false;
            isImgOn3 = false;
        }

        else
        {

            img3.enabled = true;
            isImgOn3 = true;
        }

    }

    void Update()
    {
    }
}
