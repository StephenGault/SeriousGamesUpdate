using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchDialogue : MonoBehaviour
{
    public Text driverSpeech;
    public Text driverStress;
    public GameObject gamemanager;
    string speech;
    public GameObject playerspeechUI;
    public GameObject playerspeechUI2;
    public GameObject playerspeechUI3;
    public GameObject playerspeechUI4;
    public GameObject playerspeechUI5;

    public GameObject suspectCamera;
    public GameObject playerCamera;
    
    public Text Feedback;
    string feedback;
     int question = 1;


    public void dialogueOne()
    {
        speech = "F&$@! the police!";
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }

    //dialogue 1
    public void PlayerSpeechOne()
    {
        playerspeechUI.SetActive(true);         //first dialogue
        suspectCamera.SetActive(false);
        playerCamera.SetActive(true);
    }

    public void OptionOne()
    {
        playerspeechUI.SetActive(false);
        speech = "What you going to do about it?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 15;
        question = 2;
        feedback = "+ Calm";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionTwo()
    {
        playerspeechUI.SetActive(false);
        speech = "I'll say what I want.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 15;
        question = 2;
        feedback = "- Aggresive";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionThree()
    {
        playerspeechUI.SetActive(false);
        speech = "wit?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 10;
        question = 2;
        feedback = "- Confusing";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionFour()
    {
        playerspeechUI.SetActive(false);
        speech = "Is that how you speak to people?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Aggressive";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }

    //dialogue 2
    public void PlayerSpeechTwo()
    {
        playerspeechUI2.SetActive(true);         //second dialogue
        suspectCamera.SetActive(false);
        playerCamera.SetActive(true);
    }

    public void OptionOne2()
    {
        playerspeechUI2.SetActive(false);
        speech = "We're just having a laugh aren't we.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 3;
        feedback = "+ Clear";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionTwo2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Can't be us, mate";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 25;
        question = 3;
        feedback = "+ Direct";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionThree2()
    {
        playerspeechUI2.SetActive(false);
        speech = "wit?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 10;
        question = 3;
        feedback = "- Confusing";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);

    }
    public void OptionFour2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Naw!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 3;
        feedback = "- Aggressive";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }

    //dialogue 3
    public void PlayerSpeechThree()
    {
        playerspeechUI3.SetActive(true);         //third dialogue
        suspectCamera.SetActive(false);
        playerCamera.SetActive(true);
    }

    public void OptionOne3()
    {
        playerspeechUI3.SetActive(false);
        speech = "What? I've not got any.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score -25;
        question = 4;
        feedback = "+ Aggressive";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionTwo3()
    {
        playerspeechUI3.SetActive(false);
        speech = "What if I say no?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score +25;
        question = 4;
        feedback = "+ Explanatory";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionThree3()
    {
        playerspeechUI3.SetActive(false);
        speech = "Why?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 10;
        question = 4;
        feedback = "- Direct";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionFour3()
    {
        playerspeechUI3.SetActive(false);
        speech = "You don't know nothing!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 20;
        question = 4;
        feedback = "- Accusing";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }

    //dialogue 4
    public void PlayerSpeechFour()
    {
        playerspeechUI4.SetActive(true);         //fourth dialogue
        suspectCamera.SetActive(false);
        playerCamera.SetActive(true);
    }

    public void OptionOne4()
    {
        playerspeechUI4.SetActive(false);
        speech = "Fine.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 5;
        feedback = "+ Clear";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionTwo4()
    {
        playerspeechUI4.SetActive(false);
        speech = "I haven't done nothing!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 5;
        feedback = "- Accusing";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionThree4()
    {
        playerspeechUI4.SetActive(false);
        speech = "You what?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 5;
        feedback = "- Accusing";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionFour4()
    {
        playerspeechUI4.SetActive(false);
        speech = "Mate stop being weird.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 5;
        feedback = "- Confusing";
        Feedback.text = feedback;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }

    //dialogue 5
    public void PlayerSpeechFive()
    {
        playerspeechUI5.SetActive(true);         //fourth dialogue
        suspectCamera.SetActive(false);
        playerCamera.SetActive(true);
    }

    public void OptionOne5()
    {
        playerspeechUI5.SetActive(false);
        speech = "Fine.";
        feedback = "+ Direct";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 5;
        question = 6;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionTwo5()
    {
        playerspeechUI5.SetActive(false);
        feedback = "+ Clear";
        Feedback.text = feedback;
        speech = "Alright.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 6;
    }
    public void OptionThree5()
    {
        playerspeechUI5.SetActive(false);
        speech = "Mate.";
        feedback = " - Innapropriate";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
    }
    public void OptionFour5()
    {
        playerspeechUI5.SetActive(false);
        speech = "...";
        feedback = " - Confusing";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 10;
        question = 6;
        suspectCamera.SetActive(true);
        playerCamera.SetActive(false);
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
            PlayerSpeechFive();
        }

        else if (question == 6)
        {
            this.GetComponent<SearchGuy>().BeginSearch();
            suspectCamera.SetActive(false);
            playerCamera.SetActive(false);

        }

    }



    private void Update()
    {

        driverStress.text = gamemanager.GetComponent<RatingManager>().score.ToString();
        driverSpeech.text = speech;


    }

}

