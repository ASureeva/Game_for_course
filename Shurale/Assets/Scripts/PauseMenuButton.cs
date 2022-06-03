using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuButton : MonoBehaviour
{   [SerializeField] GameObject pauseMenu = null;
    // Start is called before the first frame update
    public GameObject _setting;
    public GameObject _menu;
    public GameObject _pause_menu;
    public Button playButton;

    bool isPaused;

    public bool GetIsPaused() { return isPaused; }
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        pauseMenu.SetActive(isPaused);
        _menu.SetActive(false);
        _setting.SetActive(false);
        _pause_menu.SetActive(true);    
    }
}
