using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Synchronization : MonoBehaviour
{

    private string serverURL = "http://f0793905.xsph.ru";
    [SerializeField] Text phone;

    public void Login()
    {
        StartCoroutine(LogIn());

    }
    public IEnumerator LogIn() //����������� ������������
    {
        
        WWWForm form = new WWWForm(); //�������� ����� ��� ��������
        form.AddField("Login", $"+7{phone.text}");
        WWW www = new WWW($"{serverURL}/register.php", form); //�������� ����� �� ������
        yield return www;

        if (www.error != null) //�������� �� ������
        {
            Debug.Log(www.error);
            yield break;
        }
        else
        {
            Debug.Log("������ �������: " + www.text); //����� ������� � www.text
            SaveLoginData(phone.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");

        }
    }
    public void SaveLoginData(string login)
    {
        PlayerPrefs.SetString("phone", $"+7{login}");
    }
   
}
