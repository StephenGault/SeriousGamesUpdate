using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public GameObject textInteract;
    public GameObject player;
    public GameObject dialogueCamera;
    public GameObject SpeechUI;
    public GameObject playerCamera;
    bool alreadyTalked = false;
    public GameObject talkui;
    

    void OnTriggerEnter(Collider other)
    {
        if (alreadyTalked == false)
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
            if (alreadyTalked == false)
            {
                 if (Input.GetKeyDown(KeyCode.E))
                {

                    player.GetComponent<BasicBehaviour>().enabled = false;
                    //player.GetComponent<AimBehaviourBasic>().enabled = false;
                    dialogueCamera.SetActive(true);
                    SpeechUI.SetActive(true);
                    playerCamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
                    textInteract.SetActive(false);
                    this.GetComponent<Dialogue>().dialogueOne();
                    talkui.SetActive(false);
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

    public void Close()
    {
        alreadyTalked = true;
        dialogueCamera.SetActive(false);
        player.GetComponent<BasicBehaviour>().enabled = true;
        SpeechUI.SetActive(false);
        playerCamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
    }
}
