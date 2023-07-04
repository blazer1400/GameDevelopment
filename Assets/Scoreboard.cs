using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class Scoreboard : MonoBehaviour
{
    
    public Text text;

    public float scoreIncreaseRate = 1f; // Rate at which the score increases per second
    public float currentScore = 0f;

    private void Start()
    {
        // Start increasing the score
        InvokeRepeating("IncreaseScore", 1f, 1f); // Invoke IncreaseScore method every second
    }

    // Add 1 to score and update score text
    private void IncreaseScore()
    {
        currentScore += 1;
        text.text = "Score: " + Math.Round(currentScore).ToString();
    }
}


 