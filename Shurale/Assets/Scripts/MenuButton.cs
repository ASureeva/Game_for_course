using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public int _sceneNumber;
    public Button playButton;
    void Start()
  {
        playButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
