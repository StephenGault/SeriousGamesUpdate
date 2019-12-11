using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interrogation : MonoBehaviour
{
    public GameObject player;
    public GameObject perp;

    public GameObject playerCamera;
    public GameObject perpCamera;

    public Text driverSpeech;
    public Text driverStress;
    public GameObject gamemanager;
    string speech;
    public GameObject playerspeechUI;
    public GameObject playerspeechUI2;
    public GameObject playerspeechUI3;
    public GameObject playerspeechUI4;
    public GameObject playerspeechUI5;
    public GameObject introLine;
    public Text Feedback;
    string feedback;
    int question = 1;
    public Text name;
    
    Animator perpanim;

    private void Start()
    {
        
        perpanim = perp.GetComponent<Animator>();
    }

    public void dialogueOne()
    {
        speech = "No.";
        introLine.SetActive(false);
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }

    //dialogue 1
    public void PlayerSpeechOne()
    {
        playerspeechUI.SetActive(true);         //first dialogue
        perpanim.SetBool("react", false);
        playerCamera.SetActive(true);
        perpCamera.SetActive(false);
    }

    public void OptionOne()
    {
        playerspeechUI.SetActive(false);
        speech = "Sure. My name is Ryan Stephens, I live at 1213 UWS Road.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 30;
        question = 2;
        feedback = "+ Clear & Calm";
        Feedback.text = feedback;
        name.text = "Ryan Stephens";
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionTwo()
    {
        playerspeechUI.SetActive(false);
        speech = "Calm down. My name is Ryan Stephens, I live at 1213 UWS Road."; ;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + -10;
        question = 2;
        feedback = "- Aggressive";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        name.text = "Ryan Stephens";
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionThree()
    {
        playerspeechUI.SetActive(false);
        speech = "So...?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Silent";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionFour()
    {
        playerspeechUI.SetActive(false);
        speech = "Calm down. My name is Ryan Stephens, I live at 1213 UWS Road."; 
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 2;
        feedback = "- Aggressive";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        name.text = "Ryan Stephens";
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }

    //dialogue 2
    public void PlayerSpeechTwo()
    {
        playerspeechUI2.SetActive(true);         //second dialogue
        perpanim.SetBool("react", false);
        playerCamera.SetActive(true);
        perpCamera.SetActive(false);
    }

    public void OptionOne2()
    {
        playerspeechUI2.SetActive(false);
        speech = "I was buying an early christmas present.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 3;
        feedback = "+ Calm";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionTwo2()
    {
        playerspeechUI2.SetActive(false);
        speech = "I would like to seek legal advice.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 3;
        feedback = "- Aggressive";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionThree2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Um...?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 20;
        question = 3;
        feedback = "- Silent";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);

    }
    public void OptionFour2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Calm down! I want a lawyer.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 3;
        feedback = "- Confrontational";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }

    //dialogue 3
    public void PlayerSpeechThree()
    {
        playerspeechUI3.SetActive(true);         //third dialogue
        perpanim.SetBool("react", false);
        playerCamera.SetActive(true);
        perpCamera.SetActive(false);
    }

    public void OptionOne3()
    {
        playerspeechUI3.SetActive(false);
        speech = "It was a gift.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 40;
        question = 4;
        feedback = "+ Clear";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionTwo3()
    {
        playerspeechUI3.SetActive(false);
        speech = "I didn't! Why am I being accused?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Accusatory";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionThree3()
    {
        playerspeechUI3.SetActive(false);
        speech = "Hello?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 20;
        question = 4;
        feedback = "- Silent";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionFour3()
    {
        playerspeechUI3.SetActive(false);
        speech = "What?! I want a lawyer.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Threatening";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }

    //dialogue 4
    public void PlayerSpeechFour()
    {
        playerspeechUI4.SetActive(true);         //fourth dialogue
        perpanim.SetBool("react", false);
        playerCamera.SetActive(true);
        perpCamera.SetActive(false);
    }

    public void OptionOne4()
    {
        playerspeechUI4.SetActive(false);
        speech = "Thank you. Good day.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 45;
        question = 5;
        feedback = "+ Clear.";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionTwo4()
    {
        playerspeechUI4.SetActive(false);
        speech = "Wow. Okay then.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 5;
        feedback = "- Aggressive";
        perpanim.SetBool("react", true);
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionThree4()
    {
        playerspeechUI4.SetActive(false);
        speech = "Bye then?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 5;
        feedback = "- Blunt";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }
    public void OptionFour4()
    {
        playerspeechUI4.SetActive(false);
        speech = "?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 10;
        question = 5;
        feedback = "- Fine.";
        Feedback.text = feedback;
        playerCamera.SetActive(false);
        perpCamera.SetActive(true);
    }





    public void Advancebutton()
    {
        if (question == 1)
        {
            PlayerSpeechOne();
        }

        else if (question == 2)
        {
            PlayerSpeechTwo();
        }

        else if (question == 3)
        {
            PlayerSpeechThree();
        }

        else if (question == 4)
        {
            PlayerSpeechFour();
        }

      

        else if (question == 5)
        {
            gamemanager.GetComponent<RatingManager>().EndGameInterrogation();
        }

    }



    private void Update()
    {

        driverStress.text = gamemanager.GetComponent<RatingManager>().score.ToString();
        driverSpeech.text = speech;


    }
}
