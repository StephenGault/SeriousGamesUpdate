using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class BeginBattle : MonoBehaviour
{
    public GameObject panel;



    void OnTriggerEnter(Collider other)
    {
        panel.SetActive(true);

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Loadbattle();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            DeclineBattle();
        }
    }

    void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
    }


    public void Loadbattle()
    {
        SceneManager.LoadScene("Prototype Level");
        
    }

    public void DeclineBattle()
    {
        panel.SetActive(false);
    }

}
