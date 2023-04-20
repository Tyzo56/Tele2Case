using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Questions Easy", menuName = "Quiz/New Easy")]
public class Questions : ScriptableObject
{
    public List<QuestionEasy> QuestionsEasy;
    public List<QuestionMid> QuestionMid;
    public List<QuestionHard> QuestionHard;
}
