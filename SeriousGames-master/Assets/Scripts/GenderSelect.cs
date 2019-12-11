using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderSelect : MonoBehaviour
{
    public bool male;

    public static GenderSelect instance = null;
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

    public void MaleSelect()
    {

        male = true;
    }

    public void FemaleSelect()
    {

        male = false;
    }

}
