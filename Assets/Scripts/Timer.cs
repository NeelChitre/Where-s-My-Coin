using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] ParticleSystem winEffect;
    public TMP_Text timerText;
    public TMP_Text coinCounter;
    public TMP_Text popMessage;
    public GameObject finisher;
    float startTime;
    bool starting = false;
    IEnumerator coroutine;
    bool message = false;


    
    void Start()
    {

    }
    
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
            if (coinCounter.text == "25")
            {
                finisher.SetActive(false);
                other.gameObject.SetActive(false);
                winEffect.Play();
                starting = false;
            }
        }
        if (other.gameObject.tag == "Finisher")
        {
            message = true;
        }
        if (other.gameObject.tag == "Non")
        {
            message = false;
        }
    }
    void Update()
    {
        if (message)
        {
            popMessage.gameObject.SetActive(true);
            coroutine = WaitAndDisappear(2.0f);

        }
        else
        {
            popMessage.gameObject.SetActive(false);
        }

        if (starting) 
        {
            float t = Time.time - startTime;

            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }   
    }

    IEnumerator WaitAndDisappear(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}
