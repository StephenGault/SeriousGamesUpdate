using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefProgressManager : MonoBehaviour
{
    public GameObject robberystar1;
    public GameObject robberystar2;
    public GameObject robberystar3;
    GameObject ratings;

    public GameObject chaseStar1;
    public GameObject chaseStar2;
    public GameObject chaseStar3;

    public GameObject interrogationstar1;
    public GameObject interrogationstar2;
    public GameObject interrogationstar3;

    public GameObject breachstar1;
    public GameObject breachstar2;
    public GameObject breachstar3;

    // Start is called before the first frame update
    void Start()
    {
        ratings = GameObject.Find("ProgressManager");
    }

    // Update is called once per frame
    void Update()
    {
        //robbery chase rating
        if(ratings.GetComponent<ProgressManager>().robberyRating == 3)
        {
            robberystar1.SetActive(true);
            robberystar2.SetActive(true);           // 3 star rating
            robberystar3.SetActive(true);
        }

        if (ratings.GetComponent<ProgressManager>().robberyRating == 2)
        {
            robberystar1.SetActive(true);
            robberystar2.SetActive(true);           // 2 star rating
            robberystar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().robberyRating == 1)
        {
            robberystar1.SetActive(true);
            robberystar2.SetActive(false);           // 1 star rating
            robberystar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().robberyRating == 0)
        {
            robberystar1.SetActive(false);
            robberystar2.SetActive(false);           // 0 star rating
            robberystar3.SetActive(false);
        }

        //texting rating

        if(ratings.GetComponent<ProgressManager>().chaseRating == 3)
        {
            chaseStar1.SetActive(true);
            chaseStar2.SetActive(true);  //3 star rating
            chaseStar3.SetActive(true);
        }

        if (ratings.GetComponent<ProgressManager>().chaseRating == 2)
        {
            chaseStar1.SetActive(true);
            chaseStar2.SetActive(true);  //3 star rating
            chaseStar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().chaseRating == 1)
        {
            chaseStar1.SetActive(true);
            chaseStar2.SetActive(false);  //3 star rating
            chaseStar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().chaseRating == 0)
        {
            chaseStar1.SetActive(false);
            chaseStar2.SetActive(false);  //3 star rating
            chaseStar3.SetActive(false);
        }

        // breach

        if (ratings.GetComponent<ProgressManager>().breachRating == 3)
        {
            breachstar1.SetActive(true);
            breachstar2.SetActive(true);  //3 star rating
            breachstar3.SetActive(true);
        }

        if (ratings.GetComponent<ProgressManager>().breachRating == 2)
        {
            breachstar1.SetActive(true);
            breachstar2.SetActive(true);  //3 star rating
            breachstar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().breachRating == 1)
        {
            breachstar1.SetActive(true);
            breachstar2.SetActive(false);  //3 star rating
            breachstar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().breachRating == 0)
        {
            breachstar1.SetActive(false);
            breachstar2.SetActive(false);  //3 star rating
            breachstar3.SetActive(false);
        }

        // interview

        if (ratings.GetComponent<ProgressManager>().interrogationRating == 3)
        {
            interrogationstar1.SetActive(true);
            interrogationstar2.SetActive(true);  //3 star rating
            interrogationstar3.SetActive(true);
        }

        if (ratings.GetComponent<ProgressManager>().interrogationRating == 2)
        {
            interrogationstar1.SetActive(true);
            interrogationstar2.SetActive(true);  //3 star rating
            interrogationstar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().interrogationRating == 1)
        {
            interrogationstar1.SetActive(true);
            interrogationstar2.SetActive(false);  //3 star rating
            interrogationstar3.SetActive(false);
        }

        if (ratings.GetComponent<ProgressManager>().interrogationRating == 0)
        {
            interrogationstar1.SetActive(false);
            interrogationstar2.SetActive(false);  //3 star rating
            interrogationstar3.SetActive(false);
        }

    }
}
