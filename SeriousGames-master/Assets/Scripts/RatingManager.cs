using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RatingManager : MonoBehaviour
{
    public int score;
    public string results;
    public GameObject Level1Star;
    public GameObject Level2Star;
    public GameObject Level3Star;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (score < 0)
        {
            score = 0;
        }


        if (score>50)
        {
            Level2Star.SetActive(true);
        }

        else if (score<50)
        {
            Level2Star.SetActive(false);
            Level3Star.SetActive(true);
        }

        if(score>70)
        {
            Level3Star.SetActive(true);
        }
        else if(score<70)
        {
            Level3Star.SetActive(false);
        }

    }

    public void EndGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
