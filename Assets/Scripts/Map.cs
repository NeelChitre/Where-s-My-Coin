using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Map : MonoBehaviour
{
    public RawImage map;
    public TMP_Text mapText;

 
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            map.enabled = true;
            mapText.enabled = true;
        }
        else
        {
            map.enabled = false;
            mapText.enabled = false;
        }
    }
}
