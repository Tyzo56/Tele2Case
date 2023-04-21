using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreChecker : MonoBehaviour
{
    public void ScoreSaver()
    {
        PlayerPrefs.SetInt("points", 1 + PlayerPrefs.GetInt("points"));
        PlayerPrefs.Save();
        Debug.Log(message: "Score Saved! " + PlayerPrefs.GetInt("points"));
    }
}
