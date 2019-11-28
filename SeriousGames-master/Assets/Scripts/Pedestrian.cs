using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
     Animator anim;
    public GameObject player;
    
    bool cooldown = false;
    public GameObject Timer;
    AudioSource exertSound;
    
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        exertSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (anim.GetBool("Stagger")==false)
        {
            transform.LookAt(player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yee");
        if (other.tag == "Player")
        {
            anim.SetBool("Stagger",true);
            StartCoroutine(CooldownTime());
            if (cooldown == false)
            {
                exertSound.Play();
                Timer.GetComponent<TimerScript>().secondsCount = Timer.GetComponent<TimerScript>().secondsCount + 5;
                cooldown = true;
                
            }

        }

        else if (other.tag == "driver")
        {
            anim.SetBool("Stagger", true);

        }

    }


   

    IEnumerator CooldownTime()
    {
        
        yield return new WaitForSeconds(5);
        cooldown = false;
        anim.SetBool("Stagger", false);
    }
}
