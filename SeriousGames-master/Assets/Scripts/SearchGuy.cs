using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchGuy : MonoBehaviour
{
    bool alreadySearched = false;
    public GameObject textInteract;
 

    public GameObject player;
    public GameObject searchCamera;
    public GameObject searchUI;
    public GameObject playerCamera;
    public GameObject speechUI;
    public GameObject SearchText;
    public GameObject searchHand;
    public GameObject playerCharacterModel;
    public Button endButton;

    public GameObject drugs;
    public GameObject keys;
    public GameObject ID;
    public GameObject jacketright;
    public GameObject jacketleft;
    public GameObject pocketleft;
    public GameObject pocketright;
    public GameObject head;
    public GameObject objective;
    public GameObject wrong;
    Animator anim;

    public Text Feedback;
    string feedback;
    public GameObject gamemanager;

    public float x = 0.1f;
    public float y = 0.1f;
    public float z = 0.1f;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (alreadySearched == false)
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
            if (alreadySearched == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    alreadySearched = true;
                    speechUI.SetActive(true);
                    player.GetComponent<BasicBehaviour>().enabled = false;
                    //player.GetComponent<AimBehaviourBasic>().enabled = false;
                    searchCamera.SetActive(true);
                    
                    playerCamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
                    textInteract.SetActive(false);
                    this.GetComponent<SearchDialogue>().dialogueOne();
                    objective.SetActive(false);
                }
            }
        }
    }

    public void BeginSearch()
    {
        playerCharacterModel.SetActive(false);
        searchHand.SetActive(true);
        anim.SetBool("Search", true);
        speechUI.SetActive(false);
        SearchText.SetActive(true);
        player.GetComponent<BasicBehaviour>().enabled = false;
        //player.GetComponent<AimBehaviourBasic>().enabled = false;
        searchCamera.SetActive(true);
        searchUI.SetActive(true);
        playerCamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
        textInteract.SetActive(false);

    }

    public void EndSearch()
    {
        playerCharacterModel.SetActive(true);
        searchHand.SetActive(false);
        anim.SetBool("Search", false);
        SearchText.SetActive(false);
        player.GetComponent<BasicBehaviour>().enabled = true;
        //player.GetComponent<AimBehaviourBasic>().enabled = false;
        searchCamera.SetActive(false);
        searchUI.SetActive(false);
        playerCamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
        textInteract.SetActive(true);

        gamemanager.GetComponent<RatingManager>().EndGameBreach();
        
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            textInteract.SetActive(false);
        }
    }

    public void JacketRight()
    {
        drugs.SetActive(true);
        jacketright.SetActive(false);
        feedback = "+ Illegal substance";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        endButton.interactable = true;

    }

    public void PocketLeft()
    {
        keys.SetActive(true);
        pocketleft.SetActive(false);
        feedback = "+ Suspect keys";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 5 ;
    }

    public void PocketRight()
    {
        ID.SetActive(true);
        pocketright.SetActive(false);
        feedback = "+ Suspect ID";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 5;
    }

    public void JacketLeft()
    {
        
        jacketleft.SetActive(false);
        feedback = "+ Nothing Found";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 5;
    }

    public void Head()
    {

        head.SetActive(false);
        anim.SetBool("Angry", true);
        StartCoroutine(cooldown());
        feedback = "- Inappropriate";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 20;
    }
    public void Wrong()
    {

        wrong.SetActive(false);
        anim.SetBool("Angry", true);
        StartCoroutine(cooldown());
        feedback = "- Inappropriate";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 20;
    }

    IEnumerator cooldown()
    {
        
        yield return new WaitForSeconds(1);
        anim.SetBool("Angry", false);    
   }
}

