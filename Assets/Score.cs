using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text scoreText;

    public void AddScore(int scoreToAdd)
    {
        PlayerGlobals.GetInstance().score += scoreToAdd;
        scoreText.text = "Puntaje: "+PlayerGlobals.GetInstance().score.ToString();
    }

}
