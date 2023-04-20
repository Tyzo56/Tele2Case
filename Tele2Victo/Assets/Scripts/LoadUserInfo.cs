using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadUserInfo : MonoBehaviour
{
    [SerializeField] private Text userName, pointsText;

    private void Start()
    {

        userName.text = PlayerPrefs.GetString("phone");
        
        pointsText.text = PlayerPrefs.GetString("points");
    }
}
