using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brigdeUse : MonoBehaviour
{
    [SerializeField] private int item_id = 3;

    public Inventory inventory;


    public bool near;

    public Text hint;
    public GameObject WoodBridge;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && near){
            if (inventory.DeleteItems(item_id)){
                WoodBridge.SetActive(true);
                hint.text = "";
            }
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
