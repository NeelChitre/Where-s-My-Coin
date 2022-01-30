using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    AudioSource audioSource;
    AudioClip bgMusic;
    float musicVolume = 1f;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>(); 
        if (!audioSource.isPlaying)
        {            
             audioSource.Play();
        }

    }

    void Update() 
    {
        audioSource.volume = musicVolume;

    }

    void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<AudioSource>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public void SetVolume (float volume)
    {
        musicVolume = volume;
    }

    public void MuteAudio(bool muted)
    {
        if (muted)
        {
            musicVolume = 0;
        }
        else
        {
            musicVolume = 1;
        }
    }
}
