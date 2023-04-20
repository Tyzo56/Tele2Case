using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public QuestionsEasy obj;
    [SerializeField] private Text QuestionText;
    [SerializeField] private List<Button> Buttons;

    public int currentQuestionIndex = 0;

    private void Start()
    {
        UIUpdate();
    }

    public void UIUpdate()
    {
        QuestionText.text = obj.QuestionsJunior[currentQuestionIndex].questionText;
        for (int i = 0; i < 4; i++)
        {
            Buttons[i].transform.GetChild(0).GetComponent<Text>().text =
                obj.QuestionsJunior[currentQuestionIndex].answersText[i];
        }
    }
    
}
