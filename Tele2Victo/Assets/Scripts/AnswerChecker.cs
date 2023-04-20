using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerChecker : MonoBehaviour
{
    public int score;
    public int count = 0;
    public int correctIndex;
    public int mistakes;
    
    [SerializeField] Questions Questions;
    [SerializeField] private Text questionText;
    [SerializeField] private List<Button> Buttons;
    [SerializeField] private QuestionSwitcher questionSwitcher;
    [SerializeField] private LevelChanger LevelChanger;
    [SerializeField] private ColorChanger ColorChanger;

    public bool AnswerCheck(int inputIndex)
    {
        count++;
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
            ColorChanger.ChangeColor(Color.green);
            questionSwitcher.AfterAnswer();
            questionText.text = "Правильно!";
            for (int i = 0; i < Buttons.Count; i++)
                Buttons[i].enabled = !Buttons[i].enabled;
            score++;
            Debug.Log("Score++!");
        }
        else
        {
            ColorChanger.ChangeColor(Color.red);
            questionText.text = "Неправильно!";
            for (int i = 0; i < Buttons.Count; i++)
                Buttons[i].enabled = !Buttons[i].enabled;
            questionSwitcher.AfterAnswer();
            Buttons[inputIndex].image.color = Color.red;
            Debug.Log("You Make a Mistake!");
            mistakes++;
        }
        Buttons[correctIndex].image.color = Color.green;
        return correctIndex == inputIndex;
    }
}
