using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SphereCollider))]


public class CollectableItem : MonoBehaviour
{
    [SerializeField] private Item item;
    [SerializeField] private int amount = 1;

    public Inventory inventory;

    public bool near;

    public int invent_item = 0;
    public PlayerMover mover;
    public GameObject player;
    public DayCounter daycounter;

    public static bool GameIsPaused = false;
    public GameObject DayInterface;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public Text hint;




    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && near){
            Debug.Log("почему не работает???");
            if(!item) return;

            if (inventory){
                Debug.Log("а тут??");
                if (inventory.AddItems(item, amount)){
                    hint.text = "";
                    mainCam.SetActive(false);
                    menuPauseCam.SetActive(true);
                    DayInterface.SetActive(true); 
                    player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
                    player.SetActive(false);
                    Time.timeScale = 0f;
                    GameIsPaused = true;

                    if (daycounter){
                        daycounter.Next();
                        Destroy(gameObject);
                    }

                }
            }
        }
    }

    private void OnTriggerEnter(Collider other){
        hint.text = "Нажмите Е";
        near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hint.text = "";
        near = false;
    }

}
