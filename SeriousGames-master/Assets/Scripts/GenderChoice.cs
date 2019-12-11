using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderChoice : MonoBehaviour
{
    GameObject genderChoice;
    public GameObject maleModel;
    public GameObject femaleModel;
    // Start is called before the first frame update
    void Start()
    {
        genderChoice = GameObject.Find("PlayerSelect");
    }

    // Update is called once per frame
    void Update()
    {
        if(genderChoice.GetComponent<GenderSelect>().male == true)
        {
            maleModel.SetActive(true);
            femaleModel.SetActive(false);

        }

        else if (genderChoice.GetComponent<GenderSelect>().male == false)
        {
            maleModel.SetActive(false);
            femaleModel.SetActive(true);

        }
    }

    public void SetMale()
    {
        genderChoice.GetComponent<GenderSelect>().male = true;
        
    }

    public void SetFemale()
    {
        genderChoice.GetComponent<GenderSelect>().male = false;
    }
}
