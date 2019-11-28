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

    }
}
