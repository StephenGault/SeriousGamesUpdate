using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{

    public int robberyRating = 0;
    public int chaseRating = 0;
    public int newRobberyRating;
    public int newChaseRating;
    void Start()
    {
        DontDestroyOnLoad(this);
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
    }
}
