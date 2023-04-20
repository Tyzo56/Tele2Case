using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSwitcher : MonoBehaviour
{
    public int currentQuestionIndex = 0;

    [SerializeField] private SceneManager SceneManager;
    [SerializeField] private AnswerChecker AnswerChecker;
    [SerializeField] private Button nextButton;
    [SerializeField] private Button infoButton;
    [SerializeField] private List<Button> Buttons;
    [SerializeField] private UIChanger UiChanger;

    public void AfterAnswer()
    {
        nextButton.gameObject.SetActive(true);
        infoButton.gameObject.SetActive(true);
    }

    public void BeforeAnswer()
    {
        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[i].enabled = true;
            Buttons[i].image.color = Color.white;
        }
        nextButton.gameObject.SetActive(false);
        infoButton.gameObject.SetActive(false);
    }

    public void NextQuestion()
    {
        if(AnswerChecker.count > 4)
            SceneManager.ChangeScene("Main Menu");
        currentQuestionIndex++;
        UiChanger.UIUpdate();
        BeforeAnswer();
        for (int i = 0; i < Buttons.Count; i++)
            Buttons[i].enabled = true;
    }
}
