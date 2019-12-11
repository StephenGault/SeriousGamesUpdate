using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public GameObject fadeout;
    // Start is called before the first frame update
    public void Traffic()
    {
        StartCoroutine(Traffic1());
    }

    public void Store()
    {
        StartCoroutine(Store1());
    }

    public void quittoMenu()
    {
        StartCoroutine(Quittomenu1());
    }
    public void Breach()
    {
        StartCoroutine(Breach1());
    }

    public void Interrogation()
    {
        StartCoroutine(Interview1());
    }

    IEnumerator Traffic1()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("IntroCutscene");
    }

    IEnumerator Quittomenu1()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Menu");
    }

    IEnumerator Store1()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("ChaseIntro");
    }

    IEnumerator Breach1()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SearchCutscene");
    }

    IEnumerator Interview1()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Interrogation");
    }


}
