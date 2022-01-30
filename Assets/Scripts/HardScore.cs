using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HardScore : MonoBehaviour
{
    public TMP_Text score;
    void Update()
    {
        Scorer();
    }

    void Scorer()
    {
        string points = (1000 * HardTimer.t).ToString("f0");
        score.text = points;
    }
}
