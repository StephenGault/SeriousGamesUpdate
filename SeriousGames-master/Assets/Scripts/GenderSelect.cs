using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderSelect : MonoBehaviour
{
    public bool male;

    private void Start()
    {
        DontDestroyOnLoad(this);
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
