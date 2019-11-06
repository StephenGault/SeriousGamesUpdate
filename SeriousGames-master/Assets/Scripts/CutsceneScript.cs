using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneScript : MonoBehaviour
{
    public GameObject camera2;
    public GameObject car1;
    public GameObject car2;

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(3);
        car1.SetActive(true);
        
        camera2.SetActive(true);
        StartCoroutine(police());
    }
    
    IEnumerator police()
    {
        yield return new WaitForSeconds(1);
        car2.SetActive(true);
        StartCoroutine(end());

    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Proto");

    }
}
