using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers; 
    int questionSeen; 

    public int getCorrectAnswers() 
    {
        return correctAnswers; 
    }

    public void incrementCorrectAnswers() 
    {
        correctAnswers++; 
    }

    public int getQuestionSeen() 
    {
        return questionSeen; 
    }

    public void incrementQuestionSeen() 
    {
        questionSeen++; 
    }

    public int calculateScore() 
    {
        return Mathf.RoundToInt(correctAnswers / (float) questionSeen * 100); 
    }
}
