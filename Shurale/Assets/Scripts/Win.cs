using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public Text hint;
    public bool near;
    public int _sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (near) {
            SceneManager.LoadScene(_sceneNumber);
        }
    }

        private void OnTriggerEnter(Collider other)
    {
        hint.text = "Нажмите Е";
        near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hint.text = "";
        near = false;
    }
}
