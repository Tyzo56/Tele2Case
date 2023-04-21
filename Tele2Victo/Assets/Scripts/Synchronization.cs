using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Synchronization : MonoBehaviour
{

    private string serverURL = "http://localhost/tehnostrelka";
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

    public void setData()
    {
        StartCoroutine(UploadUserData());
    }

    public IEnumerator UploadUserData() //загрузка информации
    {

        CheckData();
        WWWForm form = new WWWForm(); //создание формы для отправки
     
        form.AddField("Login", PlayerPrefs.GetString("phone"));
        form.AddField("Points", PlayerPrefs.GetInt("points"));

        WWW www = new WWW($"{serverURL}/uploadData.php", form); //отправка формы на сервер
        yield return www;

        if (www.error != null) //проверка на ошибки
        {
            Debug.Log(www.error);
            yield break;
        }
        else
        {
            Debug.Log("Сервер ответил: " + www.text); //ответ сервера в www.text

        }
    }

    public IEnumerator GetUserData() //загрузка информации
    {

        CheckData();
        WWWForm form = new WWWForm(); //создание формы для отправки

        form.AddField("Login", PlayerPrefs.GetString("phone"));
        //form.AddField("Points", PlayerPrefs.GetString("points"));

        WWW www = new WWW($"{serverURL}/getData.php", form); //отправка формы на сервер
        yield return www;

        if (www.error != null) //проверка на ошибки
        {
            Debug.Log(www.error);
            yield break;
        }
        else
        {
            Debug.Log("Сервер ответил: " + www.text); //ответ сервера в www.text
            PlayerPrefs.SetInt("points", int.Parse(www.text));
        }
    }
    public void getData()
    {
        StartCoroutine(GetUserData());
    }

    void CheckData()
    {
        if(PlayerPrefs.HasKey("points")) //проверка на существующие данные

        {


        }
        else
        {
            PlayerPrefs.SetInt("points", 0);
        }
       
    }

}
