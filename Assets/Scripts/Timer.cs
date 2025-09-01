using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    
    float timerValue;
    
    public bool isAnsweringQuestion = false;
    public float fillFraction; 
    public bool loadNextQuestion;

    void Update()
    {
        UpdateTimer();    
    }

    public void cancelTimer() 
    {
        timerValue = 0;
    }

    void UpdateTimer() 
    {
        timerValue -= Time.deltaTime;
        
        if(isAnsweringQuestion) 
        {
            if (timerValue > 0) 
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            } else
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        }  else
        {
            if (timerValue > 0) 
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            } else 
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
                loadNextQuestion = true;
            }
        }

        Debug.Log(isAnsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
