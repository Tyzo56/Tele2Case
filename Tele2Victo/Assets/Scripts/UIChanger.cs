using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class UIChanger : MonoBehaviour
{
    [SerializeField] private LevelChanger LevelChanger;
    [SerializeField] private Text questionText;
    [SerializeField] private QuestionSwitcher QuestionSwitcher;
    [SerializeField] private List<Button> _buttons;
    [SerializeField] Questions Questions;
    

    public void UIUpdate()
    {
        switch (LevelChanger.levelIndex)
        {
            case 0:
                questionText.text = Questions.QuestionsEasy[QuestionSwitcher.currentQuestionIndex].TextOfQuestion;
                for (int i = 0; i < _buttons.Count; i++)
                {
                    _buttons[i].transform.GetChild(0).GetComponent<Text>().text =
                        Questions.QuestionsEasy[QuestionSwitcher.currentQuestionIndex].Answers[i];
                }

                Debug.Log("UI Easy!");
                break;
            case 1:
                questionText.text = Questions.QuestionMid[QuestionSwitcher.currentQuestionIndex].TextOfQuestion;
                for (int i = 0; i < _buttons.Count; i++)
                {
                    _buttons[i].transform.GetChild(0).GetComponent<Text>().text =
                        Questions.QuestionMid[QuestionSwitcher.currentQuestionIndex].Answers[i];
                }
                Debug.Log("UI Mid!");
                break;
            case 2:
                questionText.text = Questions.QuestionHard[QuestionSwitcher.currentQuestionIndex].TextOfQuestion;
                for (int i = 0; i < _buttons.Count; i++)
                {
                    _buttons[i].transform.GetChild(0).GetComponent<Text>().text =
                        Questions.QuestionHard[QuestionSwitcher.currentQuestionIndex].Answers[i];
                }
                Debug.Log("UI Hard!");
                break;
        }
    }
    
}
