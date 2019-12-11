using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStop : MonoBehaviour
{
    public Animator anim;

    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheel3;
    public GameObject wheel4;
    bool cooldown = false;
    public GameObject Timer;

    Animator wheelanim1;
    Animator wheelanim2;
    Animator wheelanim3;
    Animator wheelanim4;
    // Use this for initialization
    void Start()
    {
        wheelanim1 = wheel1.GetComponent<Animator>();
        wheelanim2 = wheel2.GetComponent<Animator>();
        wheelanim3 = wheel3.GetComponent<Animator>();
        wheelanim4 = wheel4.GetComponent<Animator>();

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yee");
        if (other.tag == "Player")
        {
            anim.speed = 0;
            wheelanim1.speed = 0;
            wheelanim2.speed = 0;
            wheelanim3.speed = 0;
            wheelanim4.speed = 0;
            if(cooldown==false)
            {
                Timer.GetComponent<TimerScript>().secondsCount = Timer.GetComponent<TimerScript>().secondsCount + 5;
                cooldown = true;
                StartCoroutine(CooldownTime());
            }
           
        }

        else if(other.tag == "driver")
        {
            anim.speed = 0;
            wheelanim1.speed = 0;
            wheelanim2.speed = 0;
            wheelanim3.speed = 0;
            wheelanim4.speed = 0;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.speed = 0.5f;
            wheelanim1.speed = 1;
            wheelanim2.speed = 1;
            wheelanim3.speed = 1;
            wheelanim4.speed = 1;
        }

        else if (other.tag == "driver")
        {
             anim.speed = 0.5f;
            wheelanim1.speed = 1;
            wheelanim2.speed = 1;
            wheelanim3.speed = 1;
            wheelanim4.speed = 1;
        }
    }

    IEnumerator CooldownTime()
    {
        yield return new WaitForSeconds(5);
        cooldown = false;
    }
   
}
