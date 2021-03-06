using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brigdeUse : MonoBehaviour
{
    [SerializeField] private int item_id = 2;

    public Inventory inventory;


    public bool near;

    public Text hint;
    public GameObject WoodBridge;
    public DayCounter daycounter;
    public GameObject finish_button;
    public Text text;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && near){
            if (daycounter.now<6 || daycounter.now>6) {
                hint.text = "У меня нет урожая";
            }
            else if ((daycounter.now==6) && (inventory.DeleteItems(item_id))){
                WoodBridge.SetActive(true);
                hint.text = "";
                text.text = "Спасение ждет дома";
                finish_button.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hint.text = "";
        near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hint.text = "";
        near = false;
    }

}
