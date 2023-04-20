using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class QuestionEasy
{
    public string TextOfQuestion;
    public List<string> Answers;
    public int CorrectAnswerID;
}
[System.Serializable]
public class QuestionMid
{
    public string TextOfQuestion;
    public List<string> Answers;
    public int CorrectAnswerID;
}
[System.Serializable]
public class QuestionHard
{
    public string TextOfQuestion;
    public List<string> Answers;
    public int CorrectAnswerID;
}


