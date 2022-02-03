using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public RawImage map;

 
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            map.enabled = true;
        }
        else
        {
            map.enabled = false;
        }
    }
}
