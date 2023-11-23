using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{

    public TMP_Text scoreText;
    public TMP_Text returnText;

    public float timeLeft = 60;

    void Start()
    {
        UpdateText();
    }

    void UpdateText() {
        if(GameObject.Find("Objectives").GetComponent<ObjectivesManager>().IsHomeNow()) {
            scoreText.text = "Puntaje: "+PlayerGlobals.GetInstance().score.ToString();
            returnText.text = "Regresa a la pizzería para obtener tu siguiente objetivo!";
        }else {
            scoreText.text = "Puntaje: "+PlayerGlobals.GetInstance().score.ToString()+"\nTiempo restante: "+Math.Floor(timeLeft).ToString();
            returnText.text = "";
        }
        
    }

    void Update()
    {
        if(GameObject.Find("Objectives").GetComponent<ObjectivesManager>().IsHomeNow()) {
            UpdateText();
            return;
        }

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            GameObject.Find("Objectives").GetComponent<ObjectivesManager>().ForceNext();
            timeLeft = 60;
        }
        UpdateText();
    }

    public void AddScore()
    {
        if(!GameObject.Find("Objectives").GetComponent<ObjectivesManager>().IsHomeNow()) {
            PlayerGlobals.GetInstance().score += (int)Math.Floor(timeLeft);
        }
        timeLeft = 60;
        UpdateText();
    }

}
