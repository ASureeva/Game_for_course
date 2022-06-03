using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start () 
    {
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/map.png");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
