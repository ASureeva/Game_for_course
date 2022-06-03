using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public bool isFullScreen = false;
    
    void Update()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
}
