using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject _setting;
    public GameObject _menu;

    public Button playButton;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
         playButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
     _menu.SetActive(false);
    _setting.SetActive(false);   
    mainCam.SetActive(true);
    menuPauseCam.SetActive(false);
    player.SetActive(true);
    Time.timeScale = 1f;
    GameIsPaused = false;
    }
}
