using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem winEffect;
    public void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Finish")
        {
            winEffect.Play();
        }
    }
}
