using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyPauseMenu : MonoBehaviour
{
    bool paused = false;
    public GameObject pausemenu;
    GameObject playercamera;
    public GameObject quitprompt;
    public GameObject fadeoutPanel;
    public GameObject options;
    private void Start()
    {
        playercamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (paused == false)
            {
                paused = true;
                PauseGame();
            }

            else if(paused == true)
            {
                paused = false;
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pausemenu.SetActive(true);
        playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
        
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausemenu.SetActive(false);
        playercamera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;

    }

    public void QuitPrompt()
    {
        quitprompt.SetActive(true);
        options.SetActive(false);
    }

    public void yesQuit()
    {
        StartCoroutine(QuitScene());
        
    }

    public void noQuit()
    {
        quitprompt.SetActive(false);
    }
    IEnumerator QuitScene()
    {
        Time.timeScale = 1;
        fadeoutPanel.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Brief");
    }

}
