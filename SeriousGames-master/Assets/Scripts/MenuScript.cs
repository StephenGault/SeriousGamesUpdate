using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioClip dundun;
    public void startGame()
    {
        SceneManager.LoadScene("Brief");
    }

    public void Close()
    {
        Application.Quit();
    }
}
