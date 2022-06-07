using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShuraleMover : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    PlayerMover player;
    public float timeLeft = 240f;
    public bool chaseState = false;
    private Animator ch_animator;
    public AudioSource MonsterChase;
    public AudioSource MonsterScream;


    // Start is called before the first frame update
    void Start()
    {
        ch_animator = GetComponent<Animator>();
        ch_animator.SetBool("state", true);
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerMover>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
            ch_animator.SetBool("state", true);
            chaseState = !chaseState;
            if ( chaseState == true ) 
            {
                navMeshAgent.speed = 4;
                timeLeft = 30f;
                MonsterChase.Play();
            }
            else 
            {
                navMeshAgent.speed = 2;
                timeLeft = 120f;
            }
        }
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // if (horizontal != 0 || vertical != 0)ch_animator.SetBool("state", true);
        // else ch_animator.SetBool("state", false);
        navMeshAgent.SetDestination(player.transform.position);
    }
    private void OnTriggerEnter(Collider other){
        if ( chaseState == false )
        {
            ch_animator.SetBool("state", false);
            timeLeft = 3f;
            navMeshAgent.speed = 0;
            chaseState = false;
            MonsterScream.Play();
        }
    }
}