using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class scoreManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreDispaly;

    private void Update()
    {
        scoreDispaly.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("obstacle"))
        {
            score++;
						Debug.Log(score);
        }
    }
}
