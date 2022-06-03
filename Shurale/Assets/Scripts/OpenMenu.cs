using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{

    public GameObject _setting;
    public GameObject _menu;
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
         playButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        _menu.SetActive(true);
        _setting.SetActive(false);
    }
}