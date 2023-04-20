using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    public int score;
    
    public int correctIndex;
    [SerializeField] Questions Questions;
    [SerializeField] private QuestionSwitcher questionSwitcher;
    [SerializeField] private LevelChanger LevelChanger;

    public bool AnswerCheck(int inputIndex)
    {
        switch (LevelChanger.levelIndex)
            {
                case 0:
                    correctIndex = Questions.QuestionsEasy[questionSwitcher.currentQuestionIndex].CorrectAnswerID;
                    break;
                case 1:
                    correctIndex = Questions.QuestionMid[questionSwitcher.currentQuestionIndex].CorrectAnswerID;
                    break;
                case 2:
                    correctIndex = Questions.QuestionHard[questionSwitcher.currentQuestionIndex].CorrectAnswerID;
                    break;
            }

        if (correctIndex == inputIndex)
        {
            questionSwitcher.AfterAnswer();
            
            score++;
            Debug.Log("Score++!");
        }
        else
        {
            Debug.Log("You Make a Mistake!");
        }
        return correctIndex == inputIndex;
    }
}
