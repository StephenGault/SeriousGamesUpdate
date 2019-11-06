using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveScenes());
    }

    // Update is called once per frame
    IEnumerator MoveScenes()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("IntroCutscene");
    }
}
