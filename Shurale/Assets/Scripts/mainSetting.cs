using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainSetting : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public GameObject player;


    void Start()
    {
        mainCam.SetActive(false);
        menuPauseCam.SetActive(true);
        pauseMenuUI.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Update()
    {
        
    }
}
