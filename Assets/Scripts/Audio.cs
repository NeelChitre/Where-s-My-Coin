using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    AudioSource audioSource;
    float musicVolume = 1f;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update() 
    {
        audioSource.volume = musicVolume;
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public void SetVolume (float volume)
    {
        musicVolume = volume;
    }

    /*public void MuteAudio(bool muted)
    {
        if (muted)
        {
            AudioListner.volume = 0;
        }
        else
        {
            AudioListner.volume = 1;
        }
    }*/
}
