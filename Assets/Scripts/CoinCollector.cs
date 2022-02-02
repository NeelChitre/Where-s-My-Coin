using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text coinCounter;
    [SerializeField] ParticleSystem coinEffect;
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
            string coinCount = coins.ToString();
            coinCounter.text = coinCount;
            coinEffect.Play();
        }
    }
}
