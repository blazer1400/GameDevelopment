using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class Score : MonoBehaviour
{
    
    public Text text;

    public float scoreIncreaseRate = 1f; // Rate at which the score increases per second
    public float currentScore = 0f;

    private void Start()
    {
        // Start increasing the score
        InvokeRepeating("IncreaseScore", 1f, 1f); // Invoke IncreaseScore method every second
    }

    private void IncreaseScore()
    {
        if (currentScore < 50) {
            currentScore += currentScore / 2;
        } else if (currentScore < 1000) {
            currentScore += currentScore / 4;
        } else {
            currentScore += currentScore / 10;
        }
        text.text = "Score: " + Math.Round(currentScore).ToString();
    }
}


 