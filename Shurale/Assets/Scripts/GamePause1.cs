using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause1 : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public static bool MapIsOpen = false;
    public GameObject pauseMenuUI;
    public GameObject DayInterface;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public GameObject player;
    public GameObject bigMap;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (MapIsOpen)
            {
                CloseMap();
            } else
            {
                OpenMap();
            }
        }
        
    }

    void Resume()
    {
        mainCam.SetActive(true);
        menuPauseCam.SetActive(false);
        pauseMenuUI.SetActive(false);
        DayInterface.SetActive(false);
        bigMap.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        mainCam.SetActive(false);
        menuPauseCam.SetActive(true);
        pauseMenuUI.SetActive(true);
        DayInterface.SetActive(false);
        bigMap.SetActive(false);
        player.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void OpenMap()
    {
        mainCam.SetActive(false);
        menuPauseCam.SetActive(true);
        pauseMenuUI.SetActive(false);
        DayInterface.SetActive(false);
        bigMap.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0f;
        MapIsOpen = true;
    }

    void CloseMap()
    {
        mainCam.SetActive(true);
        menuPauseCam.SetActive(false);
        pauseMenuUI.SetActive(false);
        bigMap.SetActive(false);
        DayInterface.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
        MapIsOpen = false;
    }
}
