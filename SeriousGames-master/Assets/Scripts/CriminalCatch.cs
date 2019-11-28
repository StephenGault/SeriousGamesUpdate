using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class CriminalCatch : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;
    public GameObject timer;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }
    public GameObject textInteract;
    void OnTriggerEnter(Collider other)
    {
       
        {
            if (other.gameObject.tag == "Player")
            {
                textInteract.SetActive(true);
                
            }
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            
                if (Input.GetKeyDown(KeyCode.E))
                {

                Debug.Log("caught");
                
                GetComponent<DriverRun>().enabled = false;
                anim.SetBool("trip", true);
                agent.isStopped = true;
                timer.GetComponent<TimerScript>().EndTimer();
                StartCoroutine(End());
            }
            
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            textInteract.SetActive(false);
        }
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(3);
        timer.GetComponent<TimerScript>().EndLevel();
    }
}
