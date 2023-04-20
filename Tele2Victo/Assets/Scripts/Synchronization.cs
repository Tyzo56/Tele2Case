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
    public IEnumerator LogIn() //регистрация пользователя
    {
        
        WWWForm form = new WWWForm(); //создание формы для отправки
        form.AddField("Login", $"+7{phone.text}");
        WWW www = new WWW($"{serverURL}/register.php", form); //отправка формы на сервер
        yield return www;

        if (www.error != null) //проверка на ошибки
        {
            Debug.Log(www.error);
            yield break;
        }
        else
        {
            Debug.Log("Сервер ответил: " + www.text); //ответ сервера в www.text
            SaveLoginData(phone.text);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");

        }
    }
    public void SaveLoginData(string login)
    {
        PlayerPrefs.SetString("phone", $"+7{login}");
    }
   
}
