using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class HardTimer : MonoBehaviour
{
    [SerializeField] ParticleSystem winEffect;
    public TMP_Text timerText;
    public TMP_Text coinCounter;
    public TMP_Text popMessage;
    public GameObject finisher;
    float startTime;
    [HideInInspector] public static float t;
    bool starting = false;
    bool message = false;
    void Start() 
    {
        t = 420;
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
                Invoke("EndMenu", 2f);
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

        }
        else
        {
            popMessage.gameObject.SetActive(false);
        }

        if (starting) 
        {
            if (t > 0)
            {
            t = 420 - (Time.time - startTime);

            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
            }
            else
            {
                timerText.text = "0:00";
                SceneManager.LoadScene(5);
            }
        }   
    }
    
    void EndMenu()
    {
        SceneManager.LoadScene(4);
    }
}
