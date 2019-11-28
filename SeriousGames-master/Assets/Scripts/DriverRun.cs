using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DriverRun : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;
    Animator anim;
    float floatLocation;
    public Vector3 steeringTarget;

    //areas
    public Transform Marker1;
    public Transform Marker2;
    public Transform Marker3;
    public Transform Marker4;
    public Transform Marker5;
    public Transform Marker6;
    public Transform Marker7;
    public Transform Marker8;
    public Transform Marker9;


    public AudioSource footstep1;
    public AudioSource footstep2;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()

    {
        
        if ( !agent.pathPending)
        {
            if(footstep1.isPlaying==false)
            {
                footstep1.Play();
                footstep2.Play();
            }
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    randomLocation();
                }
            }
        }

    }

    void randomLocation()
    {
        anim.SetBool("walking", true);
        floatLocation = (Random.Range(0, 10));

        if (floatLocation < 1.1)
        {
            agent.destination = Marker1.position;
        }

        else if (floatLocation == 2)
        {
            agent.destination = Marker2.position;
        }

        else if (floatLocation == 3)
        {
            agent.destination = Marker3.position;
        }

        else if (floatLocation == 4)
        {
            agent.destination = Marker4.position;
        }

        else if (floatLocation == 5)
        {
            agent.destination = Marker5.position;
        }

        else if (floatLocation == 6)
        {
            agent.destination = Marker6.position;
        }

        else if (floatLocation == 7)
        {
            agent.destination = Marker7.position;
        }

        else if (floatLocation == 8)
        {
            agent.destination = Marker8.position;
        }

        else if (floatLocation == 9)
        {
            agent.destination = Marker9.position;
        }

    }


}
