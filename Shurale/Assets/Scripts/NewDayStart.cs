using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewDayStart : MonoBehaviour
{


    public GameObject player;
    public static bool GameIsPaused = false;
    public GameObject DayInterface;
    public GameObject bigMap;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public Button playButton;

    void Start()
    {
         playButton.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick(){
        mainCam.SetActive(true);
        menuPauseCam.SetActive(false);
        DayInterface.SetActive(false);
        bigMap.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
   
    }
}
