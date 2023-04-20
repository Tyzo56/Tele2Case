using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour
{
    [SerializeField] private GameObject EndPanele;
    [SerializeField] private Text endText;
    [SerializeField] private Button endButton;
    [SerializeField] private AnswerChecker AnswerChecker;

    public void SetEndPanel()
    {
        endText.text = "Вы ответили на " + AnswerChecker.score + " из 5 вопросов.";
        EndPanele.SetActive(true);
        endButton.gameObject.SetActive(true);
    }
}
