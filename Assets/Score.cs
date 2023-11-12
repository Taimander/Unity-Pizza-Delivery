using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public int currentScore = 0;

    public TMP_Text scoreText;

    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        scoreText.text = "Puntaje: "+currentScore.ToString();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
