using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShuraleMover : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    PlayerMover player;
    private Animator ch_animator;


    // Start is called before the first frame update
    void Start()
    {
        ch_animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerMover>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)ch_animator.SetBool("state", false);
        else ch_animator.SetBool("state", true);
        navMeshAgent.SetDestination(player.transform.position);
    }
}