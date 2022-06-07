using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenSetting : MonoBehaviour
{

    public GameObject _openUI;
    public GameObject _menu;
    public GameObject _closeUI;
    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        _menu.SetActive(false);
        _openUI.SetActive(true);
        _closeUI.SetActive(false);
    }
}
