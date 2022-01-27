using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsSound : MonoBehaviour
{
    [SerializeField] AudioClip walkSound;
    [SerializeField] AudioClip landingSound;
    [SerializeField] AudioClip coinCollect;
    AudioSource AS;

    void Start()
    {
       AS = GetComponent<AudioSource>(); 
    }

    void LandSound()
    {
        AS.PlayOneShot(landingSound);
    }

    void Footsteps1()
    {
        AS.PlayOneShot(walkSound);
    }

     void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Coins")
        {
            AS.PlayOneShot(coinCollect);
        }
    }
}
