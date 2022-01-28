using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] ParticleSystem winEffect;
    int coins;
    void Start()
    {
        coins = 0;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Coins")
        {
            coins+=1;
            other.gameObject.SetActive(false);
            Debug.Log(coins);
        }
        if (other.gameObject.tag == "Finish")
        {
            other.gameObject.SetActive(false);
            winEffect.Play();

        }
    }
}
