using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] ParticleSystem winEffect;
    public TMP_Text timerText;
    float startTime;
    bool starting = false;

    
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Start")
        {
            other.gameObject.SetActive(false);
            starting = true;
            startTime = Time.time;
        }

        if (other.gameObject.tag == "Finish")
        {
            other.gameObject.SetActive(false);
            winEffect.Play();
            starting = false;
        }
    }
    void Update()
    {
        if (starting) 
        {
            float t = Time.time - startTime;

            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
    }
}
