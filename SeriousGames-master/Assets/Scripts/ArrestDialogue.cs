using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ArrestDialogue : MonoBehaviour
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



    //dialogue 1
   


    public void OptionOne()
    {
        playerspeechUI.SetActive(false);
        playerspeechUI2.SetActive(true);
        
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionTwo()
    {
        playerspeechUI.SetActive(false);
        playerspeechUI2.SetActive(true);
        
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 20;
        question = 2;
        feedback = "+ Polite.";
        Feedback.text = feedback;
    }
    public void OptionThree()
    {
        playerspeechUI.SetActive(false);
        playerspeechUI2.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }
    public void OptionFour()
    {
        playerspeechUI.SetActive(false);
        playerspeechUI2.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 30;
        question = 2;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }

    //dialogue 2
   

    public void OptionOne2()
    {
        playerspeechUI2.SetActive(false);
        playerspeechUI3.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 3;
        feedback = "+ Clear";
        Feedback.text = feedback;
    }
    public void OptionTwo2()
    {
        playerspeechUI2.SetActive(false);
        playerspeechUI3.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 3;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionThree2()
    {
        playerspeechUI2.SetActive(false);
        playerspeechUI3.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 50;
        question = 3;
        feedback = "- Aggressive";
        Feedback.text = feedback;

    }
    public void OptionFour2()
    {
        playerspeechUI2.SetActive(false);
        playerspeechUI3.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 3;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }

    //dialogue 3


    public void OptionOne3()
    {
        playerspeechUI3.SetActive(false);
        playerspeechUI4.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 40;
        question = 4;
        feedback = "+ Clear";
        Feedback.text = feedback;
    }
    public void OptionTwo3()
    {
        playerspeechUI3.SetActive(false);
        playerspeechUI4.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }
    public void OptionThree3()
    {
        playerspeechUI3.SetActive(false);
        playerspeechUI4.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionFour3()
    {
        playerspeechUI3.SetActive(false);
        playerspeechUI4.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 4;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }

    //dialogue 4
 

    public void OptionOne4()
    {
        playerspeechUI4.SetActive(false);
        playerspeechUI5.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 45;
        question = 5;
        feedback = "+ Clear and Helpful";
        Feedback.text = feedback;
    }
    public void OptionTwo4()
    {
        playerspeechUI4.SetActive(false);
        playerspeechUI5.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 40;
        question = 5;
        feedback = "- Aggressive";
        Feedback.text = feedback;
    }
    public void OptionThree4()
    {
        playerspeechUI4.SetActive(false);
        playerspeechUI5.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 35;
        question = 5;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }
    public void OptionFour4()
    {
        playerspeechUI4.SetActive(false);
        playerspeechUI5.SetActive(true);
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 5;
        feedback = "- Confusing";
        Feedback.text = feedback;
    }

    //dialogue 5


    public void OptionOne5()
    {
        playerspeechUI5.SetActive(false);
        
        feedback = "Confusing";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
        SceneManager.LoadScene("Brief");
    }
    public void OptionTwo5()
    {
        playerspeechUI5.SetActive(false);
        
        Feedback.text = feedback;
        speech = "No problem, thank you.";
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score + 35;
        question = 6;
        SceneManager.LoadScene("Brief");
    }
    public void OptionThree5()
    {
        playerspeechUI5.SetActive(false);
        
        feedback = " - Aggressive";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
        SceneManager.LoadScene("Brief");
    }
    public void OptionFour5()
    {
        playerspeechUI5.SetActive(false);
        
        feedback = " - Abrupt";
        Feedback.text = feedback;
        gamemanager.GetComponent<RatingManager>().score = gamemanager.GetComponent<RatingManager>().score - 25;
        question = 6;
        SceneManager.LoadScene("Brief");
    }










    private void Update()
    {

        driverStress.text = gamemanager.GetComponent<RatingManager>().score.ToString();
        driverSpeech.text = speech;


    }

}
