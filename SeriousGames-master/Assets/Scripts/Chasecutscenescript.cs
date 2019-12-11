using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chasecutscenescript : MonoBehaviour
{
    
    public GameObject fade;

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(6);
       
        StartCoroutine(end());
    }

    

    IEnumerator end()
    {
        yield return new WaitForSeconds(1);
        fade.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("chase");

    }
}
