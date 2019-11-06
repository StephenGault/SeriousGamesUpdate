using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
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
    public Text Feedback;
    string feedback;
     int question = 1;
    

    public void dialogueOne()
    {
        speech = "Good morning, officer.";
    }

    //dialogue 1
    public void PlayerSpeechOne()
    {
        playerspeechUI.SetActive(true);         //first dialogue
    }

    public void OptionOne()
    {
        playerspeechUI.SetActive(false);
        speech = "What?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionTwo()
    {
        playerspeechUI.SetActive(false);
        speech = "How can I help you, officer?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 20;
        question = 2;
        feedback = "+ Polite.";
        Feedback.text = feedback;
    }
    public void OptionThree()
    {
        playerspeechUI.SetActive(false);
        speech = "What?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }
    public void OptionFour()
    {
        playerspeechUI.SetActive(false);
        speech = "What?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }

    //dialogue 2
    public void PlayerSpeechTwo()
    {
        playerspeechUI2.SetActive(true);         //second dialogue
    }

    public void OptionOne2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Yes, I was on my phone for a bit while driving, i apologise";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 3;
        feedback = "+ Clear";
        Feedback.text = feedback;
    }
    public void OptionTwo2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Um?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 3;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionThree2()
    {
        playerspeechUI2.SetActive(false);
        speech = "Okay, please calm down.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 50;
        question = 3;
        feedback = "- Aggressive";
        Feedback.text = feedback;

    }
    public void OptionFour2()
    {
        playerspeechUI2.SetActive(false);
        speech = "I am co-operating, please calm down sir.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 3;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }

    //dialogue 3
    public void PlayerSpeechThree()
    {
        playerspeechUI3.SetActive(true);         //third dialogue
    }

    public void OptionOne3()
    {
        playerspeechUI3.SetActive(false);
        speech = "I do not currently have it with me, I will take it down to the local station later today sir.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 40;
        question = 4;
        feedback = "+ Clear";
        Feedback.text = feedback;
    }
    public void OptionTwo3()
    {
        playerspeechUI3.SetActive(false);
        speech = "Sorry! I don't have it with me.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }
    public void OptionThree3()
    {
        playerspeechUI3.SetActive(false);
        speech = "What?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionFour3()
    {
        playerspeechUI3.SetActive(false);
        speech = "?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }

    //dialogue 4
    public void PlayerSpeechFour()
    {
        playerspeechUI4.SetActive(true);         //fourth dialogue
    }

    public void OptionOne4()
    {
        playerspeechUI4.SetActive(false);
        speech = "grrr, okay Officer.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 45;
        question = 5;
        feedback = "+ Clear and Helpful";
        Feedback.text = feedback;
    }
    public void OptionTwo4()
    {
        playerspeechUI4.SetActive(false);
        speech = "Sorry! I don't have it with me.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 5;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }
    public void OptionThree4()
    {
        playerspeechUI4.SetActive(false);
        speech = "What?!";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 5;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionFour4()
    {
        playerspeechUI4.SetActive(false);
        speech = "?";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 5;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }

    //dialogue 5
            public void PlayerSpeechFive()
            {
                playerspeechUI5.SetActive(true);         //fourth dialogue
            }

            public void OptionOne5()
            {
                playerspeechUI5.SetActive(false);
                speech = "- Uh okay, goodbye.";
        feedback = "Confusing";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
            }
            public void OptionTwo5()
            {
                playerspeechUI5.SetActive(false);
        feedback = "+ Polite";
        Feedback.text = feedback;
        speech = "No problem, thank you.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 6;
            }
            public void OptionThree5()
            {
                playerspeechUI5.SetActive(false);
                speech = "Okay, goodbye then.";
        feedback = " - Aggressive";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
            }
            public void OptionFour5()
            {
                playerspeechUI5.SetActive(false);
                speech = "Bye?";
        feedback = " - Abrupt";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
            }







    public void Advancebutton()
    {
        if(question==1)
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

        else if(question == 6)
        {
            GetComponent<Talk>().Close();
        }

    }



    private void Update()
    {
        
        driverStress.text = gamemanager.GetComponent<RatingManager>().score.ToString();
        driverSpeech.text = speech;
        
        
    }


}

