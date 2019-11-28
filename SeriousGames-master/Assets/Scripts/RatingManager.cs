using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RatingManager : MonoBehaviour
{
    public int score;
    
    public GameObject Level1Star;
    public GameObject Level2Star;
    public GameObject Level3Star;
    int rating;
    GameObject menu;
    public GameObject fadeout;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (score < 30)
        {
            score = 0;
            rating = 0;
            Level1Star.SetActive(false);
        }

        if(score>30)
        {
            Level1Star.SetActive(true);
            rating = 1;
        }


        if (score>50)
        {
            Level2Star.SetActive(true);
            rating = 2;
        }

        else if (score<50)
        {
            Level2Star.SetActive(false);
            Level3Star.SetActive(false);
            rating = 2;
        }

        if(score>70)
        {
            Level3Star.SetActive(true);
            rating = 3;
        }
        else if(score<70)
        {
            Level3Star.SetActive(false);
        }

    }

    public void EndGame()
    {
        menu = GameObject.Find("ProgressManager");
        menu.GetComponent<ProgressManager>().newChaseRating = rating;
        menu.GetComponent<ProgressManager>().UpdateRating();
        StartCoroutine(fade());
    }
    public IEnumerator fade()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Brief");
    }
}
