using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Levels _levels;
    [SerializeField] private UIManager UiManager;
    public int currentQuestionIndex = 0;

    private int score = 0;

    public void SetLevel(int levelId)
    {
        
    }
    public void CheckAnswer(int index)
    {
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

    public void Easy()
    {
        SetLevel(0);
    }
    public void Mid()
    {
        SetLevel(1);
    }
    public void Hard()
    {
        SetLevel(2);
    }
    
}
