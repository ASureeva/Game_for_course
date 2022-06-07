using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

[RequireComponent(typeof(SphereCollider))]

public class UseItem : MonoBehaviour
{

    [SerializeField] private int item_id_seeds;
    [SerializeField] private int item_id_bucket;

    [SerializeField] private Item item;
    [SerializeField] private int amount = 1;

    public Inventory inventory;


    public bool near;

    public PlayerMover mover;
    public GameObject player;
    public DayCounter daycounter;

    public static bool GameIsPaused = false;
    public GameObject DayInterface;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public Text hint;
    public Text text;
    public GameObject monster;
    public ShuraleMover controller_monster;


    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && near){

            if (inventory){
                if (daycounter.now == 1){
                    hint.text = "Вы еще не посадили";
                }
                else if (inventory.DeleteItems(item_id_seeds) && (daycounter.now == 2)){
                    Debug.Log("0000");   
                    controller_monster.timeLeft = 0f;
                    controller_monster.chaseState = true;
                    controller_monster.MonsterChase.Stop();
                    hint.text = "";
                    text.text = "Новый день";
                    mainCam.SetActive(false);
                    menuPauseCam.SetActive(true);
                    DayInterface.SetActive(true); 
                    monster.transform.position = new Vector3(80.97f, 2.1f, 116.84f);
                    player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
                    player.SetActive(false);
                    Time.timeScale = 0f;
                    GameIsPaused = true;

                    if (daycounter){
                        daycounter.Next();
                        // Destroy(gameObject);
                    }
                } 
                else if (daycounter.now == 3){
                    hint.text = "Урожай еще не взошел(";
                } 
                else if (inventory.DeleteItems(item_id_bucket) && (daycounter.now == 4)){
                    hint.text = "";
                    controller_monster.timeLeft = 0f;
                    controller_monster.chaseState = true;
                    controller_monster.MonsterChase.Stop();
                    text.text = "Новый день";
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
                        // Destroy(gameObject);
                    }
                }
                else if (inventory.AddItems(item, amount) && (daycounter.now == 5)){
                    hint.text = "";
                    controller_monster.timeLeft = 0f;
                    controller_monster.chaseState = true;
                    controller_monster.MonsterChase.Stop();
                    text.text = "Новый день";
                    mainCam.SetActive(false);
                    menuPauseCam.SetActive(true);
                    DayInterface.SetActive(true); 
                    monster.transform.position = new Vector3(-167.97f, 2.1f, 146.84f);
                    player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
                    player.SetActive(false);
                    Time.timeScale = 0f;
                    GameIsPaused = true;

                    if (daycounter){
                        daycounter.Next();
                        // Destroy(gameObject);
                    }
                }
                else {
                    hint.text = "Ничего не растет(";
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
