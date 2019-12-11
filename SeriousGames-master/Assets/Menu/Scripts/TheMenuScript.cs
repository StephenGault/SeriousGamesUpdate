using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class TheMenuScript : MonoBehaviour {

    public AudioMixer Music;
    

    public void musicSlider (float musicVol)
    {
        // Potential fix that creates a logarithmically scalable slider control.
        Music.SetFloat("MusicVol", Mathf.Log10(musicVol) * 20);
        Music.SetFloat("Music Volume", musicVol);
        Debug.Log(musicVol);
    }




}
