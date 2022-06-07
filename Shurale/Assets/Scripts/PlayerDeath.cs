using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDeath : MonoBehaviour
{
    public bool near;
    public PlayerMover mover;
    public GameObject player;
    public static bool GameIsPaused = false;
    public GameObject DayInterface;
    public GameObject mainCam;
    public GameObject menuPauseCam;
    public Text text;
    public GameObject monster;
    public ShuraleMover controller_monster;
    public DayCounter daycounter;
    public int day_text;
    

    void Update()
    {
        if (near) {
            day_text = daycounter.now;
            Debug.Log(day_text);
            if (day_text==1) {
                monster.transform.position = new Vector3(-95.91f, 2.1f, -121.84f);
            } else if (day_text==2) {
                monster.transform.position = new Vector3(26.97f, 2.1f, -14.84f);
            } else if (day_text==3) {
                monster.transform.position = new Vector3(80.97f, 2.1f, 116.84f);
            } else if (day_text==4) {
                monster.transform.position = new Vector3(20.97f, 5.7f, -4.84f);
            } else if (day_text==5) {
                monster.transform.position = new Vector3(20.97f, 5.7f, -4.84f);
            } else if (day_text==6) {
                monster.transform.position = new Vector3(-167.97f, 2.1f, 146.84f);
            } else {
                monster.transform.position = new Vector3(20.97f, 5.7f, -4.84f);  
            }
            controller_monster.timeLeft = 0f;
            controller_monster.chaseState = true;
            controller_monster.MonsterChase.Stop();
            player.transform.position = new Vector3(15.42f, 3.87f, -10.65f);
            text.text = "Вам показалось, что вы умерли";
            mainCam.SetActive(false);
            menuPauseCam.SetActive(true);
            DayInterface.SetActive(true); 
            Debug.Log("ojojojojojojojojojojojojjojo");
            player.SetActive(false);
            Time.timeScale = 0f;
            GameIsPaused = true;
            near = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        near = false;
    }
}
