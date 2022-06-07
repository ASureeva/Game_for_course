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
    public int number_of_item;
    public int invent_item = 0;
    public PlayerMover mover;
    public GameObject player;
    public DayCounter daycounter;

    public static bool GameIsPaused = false;
    public GameObject DayInterface;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public Text hint;
    public GameObject monster;
    public ShuraleMover controller_monster;




    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && near){
            if(!item) return;

            if (inventory){
                if (number_of_item==0) {
                    if (daycounter.now==1 ) {
                         if (inventory.AddItems(item, amount)){
                            hint.text = "";
                            controller_monster.timeLeft = 0f;
                            controller_monster.chaseState = true;
                            controller_monster.MonsterChase.Stop();
                            mainCam.SetActive(false);
                            menuPauseCam.SetActive(true);
                            DayInterface.SetActive(true); 
                            player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
                            monster.transform.position = new Vector3(26.97f, 2.1f, -14.84f);
                            player.SetActive(false);
                            Time.timeScale = 0f;
                            GameIsPaused = true;

                            if (daycounter){
                                daycounter.Next();
                                Destroy(gameObject);
                            }

                }
                    } else {
                          hint.text = "Сегодня я не хочу этого делать";
                    }
                }
                if (number_of_item==1) {
                    if (daycounter.now==3){
                         if (inventory.AddItems(item, amount)){
                            hint.text = "";
                            controller_monster.timeLeft = 0f;
                            controller_monster.chaseState = true;
                            controller_monster.MonsterChase.Stop();
                            mainCam.SetActive(false);
                            menuPauseCam.SetActive(true);
                            DayInterface.SetActive(true); 
                            monster.transform.position = new Vector3(20.97f, 5.7f, -4.84f);
                            player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
                            player.SetActive(false);
                            Time.timeScale = 0f;
                            GameIsPaused = true;

                            if (daycounter){
                                daycounter.Next();
                                Destroy(gameObject);
                            }

                }

                    } else {
                          hint.text = "Сегодня я не хочу этого делать";
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
