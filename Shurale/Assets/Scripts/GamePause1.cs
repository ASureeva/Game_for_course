using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause1 : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public static bool MapIsOpen = false;
    public GameObject instruct;
    public GameObject settings;
    public GameObject interfaceGame;
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
        Cursor.visible = false;
        mainCam.SetActive(true);
        menuPauseCam.SetActive(false);
        pauseMenuUI.SetActive(false);
        DayInterface.SetActive(false);
        bigMap.SetActive(false);
        instruct.SetActive(false);
        settings.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        mainCam.SetActive(false);
        Cursor.visible = true;
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
        Cursor.visible = true;
        mainCam.SetActive(false);
        menuPauseCam.SetActive(true);
        pauseMenuUI.SetActive(false);
        DayInterface.SetActive(false);
        bigMap.SetActive(true);
        instruct.SetActive(false);
        settings.SetActive(false);
        player.SetActive(false);
        Time.timeScale = 0f;
        MapIsOpen = true;
    }

    void CloseMap()
    {
        Cursor.visible = false;
        mainCam.SetActive(true);
        menuPauseCam.SetActive(false);
        pauseMenuUI.SetActive(false);
        bigMap.SetActive(false);
        DayInterface.SetActive(false);
        instruct.SetActive(false);
        settings.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
        MapIsOpen = false;
    }
}
