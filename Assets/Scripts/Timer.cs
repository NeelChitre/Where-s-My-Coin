using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
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
    [SerializeField] AudioClip success;
    AudioSource AS;
    
    void Start() 
    {
        AS = GetComponent<AudioSource>();
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
                AS.PlayOneShot(success);
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
            t = Time.time - startTime;

            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }   
    }
    
    void EndMenu()
    {
        SceneManager.LoadScene(3);
    }
}
