using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject textInteract;
    public GameObject player;
    public GameObject playercamera;
    bool Ended = false;
    public GameObject EndUI;
    public GameObject choice;
    void OnTriggerEnter(Collider other)
    {
        if (Ended == false)
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
            if (Ended == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    player.GetComponent<BasicBehaviour>().enabled = false;
                    //player.GetComponent<AimBehaviourBasic>().enabled = false;
                    
                    playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
                    textInteract.SetActive(false);
                    choice.SetActive(true);
                    
                }
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

    public void YesClick()
    {
        player.GetComponent<BasicBehaviour>().enabled = false;
        //player.GetComponent<AimBehaviourBasic>().enabled = false;

        playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
        textInteract.SetActive(false);
        EndUI.SetActive(true);
        Ended = true;
        choice.SetActive(false);
    }

    public void NoClick()
    {
        textInteract.SetActive(true);
        
        
        player.GetComponent<BasicBehaviour>().enabled = true;
        
        playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
        choice.SetActive(false);
    }
}
