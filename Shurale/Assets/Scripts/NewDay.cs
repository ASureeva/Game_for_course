using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDay : MonoBehaviour
{

    public bool near;
    public int invent_item = 0;
    public PlayerMover mover;
    public GameObject player;
    public DayCounter daycounter;
    public Inventory inventory;

    public static bool GameIsPaused = false;
    public GameObject DayInterface;
    public GameObject mainCam;
    public GameObject menuPauseCam;


    void Update(){
        for (int i = 0; i < inventory.GetSize(); i ++){
            Debug.Log(inventory.GetItem(i).id + "---------------------------");
            if (inventory.GetItem(i).id == invent_item){
                mainCam.SetActive(false);
                menuPauseCam.SetActive(true);
                DayInterface.SetActive(true); 
                player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
                player.SetActive(false);
                Time.timeScale = 0f;
                GameIsPaused = true;

                if (daycounter){
                    daycounter.Next();
                }
            }
        }
    }


    private void OnTriggerEnter(Collider other){

        near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        near = false;
    }

}