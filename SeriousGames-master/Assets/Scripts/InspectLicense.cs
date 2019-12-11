using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InspectLicense : MonoBehaviour
{
    public GameObject textInteract;
    public GameObject player;
    public GameObject playercamera;
    bool Inspected = false;
    public GameObject InspectionCamera;
    public GameObject gamemanager;
    public Text Feedback;
    string feedback;
    void OnTriggerEnter(Collider other)
    {
        if (Inspected == false)
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
            if (Inspected == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    player.GetComponent<BasicBehaviour>().enabled = false;
                    //player.GetComponent<AimBehaviourBasic>().enabled = false;

                    playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
                    textInteract.SetActive(false);
                    InspectionCamera.SetActive(true);
                    StartCoroutine(CameraView());
                    

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

    IEnumerator CameraView()
    {
        yield return new WaitForSeconds(5);
        playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
        player.GetComponent<BasicBehaviour>().enabled = true;
        textInteract.SetActive(false);
        InspectionCamera.SetActive(false);
        Inspected = true;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 30;
        feedback = "+ License Plate";
        Feedback.text = feedback;
        
        this.gameObject.SetActive(false);

    }

  
}
