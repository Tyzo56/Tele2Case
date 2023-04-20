using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private AnswerChecker AnswerChecker;
    public void Click(int index)
    {
        AnswerChecker.AnswerCheck(index);
    }
}
