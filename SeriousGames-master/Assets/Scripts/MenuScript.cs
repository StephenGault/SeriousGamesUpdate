using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioClip dundun;
    public GameObject fadeout;
    public void startGame()
    {
        StartCoroutine(Fade());
    }

    public void Close()
    {
        Application.Quit();
    }

    public IEnumerator Fade()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Brief");
    }
}
