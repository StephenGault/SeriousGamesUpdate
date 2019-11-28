using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float secondsCount;
    private int minuteCount;
    private int hourCount;
    GameObject progressmanager;
    public GameObject fadeout;
    public GameObject star3;
    public GameObject star2;
    public GameObject star1;
    int rating = 3;

    bool ended = false;
    void Update()
    {
        if(ended==false)
        {
            UpdateTimerUI();
        }


        if(minuteCount==1||secondsCount==30)
        {
            star3.SetActive(false);
            rating = 2;
        }

        if (minuteCount == 2 || secondsCount == 20)
        {
            star2.SetActive(false);
            rating = 1;
        }

        if (minuteCount == 3)
        {
            star1.SetActive(false);
            rating = 0;
            EndLevel();
        }

    }
    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

    public void EndTimer()
    {
        ended = true;
    }

    public void EndLevel()
    {
        progressmanager = GameObject.Find("ProgressManager");
        progressmanager.GetComponent<ProgressManager>().newRobberyRating = rating;
        progressmanager.GetComponent<ProgressManager>().UpdateRating();

        StartCoroutine(Fade());

    }

    IEnumerator Fade()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Brief");
    }

}
