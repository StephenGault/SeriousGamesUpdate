using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{

    public int robberyRating = 0;
    public int chaseRating = 0;
    public int breachRating = 0;
    public int interrogationRating = 0;
    public int newRobberyRating;
    public int newChaseRating;
    public int newBreachRating;
    public int newInterrogationRating;

    public static ProgressManager instance = null;
    void Start()
    {
         
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateRating()
    {
        if(newRobberyRating>robberyRating)
        {
            robberyRating = newRobberyRating;
        }

        if(newChaseRating>chaseRating)
        {
            chaseRating = newChaseRating;
        }

        if(newBreachRating>breachRating)
        {
            breachRating = newBreachRating;
        }

        if (newInterrogationRating > interrogationRating)
        {
            interrogationRating = newInterrogationRating;
        }
    }
}
