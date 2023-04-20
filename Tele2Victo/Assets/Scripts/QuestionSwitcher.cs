using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSwitcher : MonoBehaviour
{
    public int currentQuestionIndex = 0;
    [SerializeField] private Button nextButton;
    [SerializeField] private Button infoButton;
    [SerializeField] private UIChanger UiChanger;

    public void AfterAnswer()
    {
        nextButton.gameObject.SetActive(true);
        infoButton.gameObject.SetActive(true);
    }

    public void BeforeAnswer()
    {
        nextButton.gameObject.SetActive(false);
        infoButton.gameObject.SetActive(false);
    }

    public void NextQuestion()
    {
        currentQuestionIndex++;
        UiChanger.UIUpdate();
        BeforeAnswer();
    }
}
