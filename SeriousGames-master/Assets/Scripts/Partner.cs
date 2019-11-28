using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Partner : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()

    {

        agent.destination = player.position;

        if (agent.remainingDistance > agent.stoppingDistance)
        { 
        anim.SetBool("walking", true);
    }

        else
            anim.SetBool("walking", false);

            }
    }

