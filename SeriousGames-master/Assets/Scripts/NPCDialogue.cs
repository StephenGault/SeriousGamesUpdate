using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public AudioSource guy1;
    public AudioSource guy2;
    public AudioSource woman1;
    public AudioSource woman2;
    float choice;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PickLine());
    }

    IEnumerator PickLine()
    {
        yield return new WaitForSeconds(3);
        choice = (Random.Range(0, 5));

        if (choice == 0)
        {
            guy1.Play();
            StartCoroutine(PickLine());
        }
        if (choice == 1)
        {
            guy1.Play();
            StartCoroutine(PickLine());
        }
        if (choice == 2)
        {
            guy2.Play();
            StartCoroutine(PickLine());
        }
        if (choice == 3)
        {
            woman1.Play();
            StartCoroutine(PickLine());
        }
        if(choice == 4)
        {
            woman2.Play();
            StartCoroutine(PickLine());
        }
    }
}
