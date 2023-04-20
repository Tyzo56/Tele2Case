using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] GameObject[] circles;
    [SerializeField] private AnswerChecker AnswerChecker;

    public void ChangeColor(Color color)
    {
        circles[AnswerChecker.count].GetComponent<SpriteRenderer>().color = color;
    }
}
