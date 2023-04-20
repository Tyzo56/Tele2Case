using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private QuestionsEasy obj;
    [SerializeField] private UIManager UiManager;

    private int score = 0;
    public void CheckAnswer(int index)
    {
        if (index == obj.QuestionsJunior[UiManager.currentQuestionIndex].corretAnswerIndex)
        {
            score++;
            UiManager.currentQuestionIndex++;
            try
            {
                UiManager.UIUpdate();
            }
            catch
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
            
        Debug.Log(score);
    }
    
    
    public void First()
    {
        CheckAnswer(0);
    }
    public void Second()
    {
        CheckAnswer(1);
    }
    public void Third()
    {
        CheckAnswer(2);
    }
    public void Fourth()
    {
        CheckAnswer(3);
    }

}
