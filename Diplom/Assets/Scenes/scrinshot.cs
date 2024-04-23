using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrinshot : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            int Rand = Random.Range(0, 100000);
            ScreenCapture.CaptureScreenshot("Screen" + Rand + ".png");
        }     
    }
}
