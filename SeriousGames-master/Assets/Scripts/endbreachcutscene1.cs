using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endbreachcutscene1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Transition());
    }

   IEnumerator Transition()
    {

        yield return new WaitForSeconds(16);
        SceneManager.LoadScene("BreachSearch");
            

    }
}
