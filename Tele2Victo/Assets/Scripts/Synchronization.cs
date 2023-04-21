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

    public void setData()
    {
        StartCoroutine(UploadUserData());
    }

    public IEnumerator UploadUserData() //�������� ����������
    {

        CheckData();
        WWWForm form = new WWWForm(); //�������� ����� ��� ��������
     
        form.AddField("Login", PlayerPrefs.GetString("phone"));
        form.AddField("Points", PlayerPrefs.GetInt("points"));

        WWW www = new WWW($"{serverURL}/uploadData.php", form); //�������� ����� �� ������
        yield return www;

        if (www.error != null) //�������� �� ������
        {
            Debug.Log(www.error);
            yield break;
        }
        else
        {
            Debug.Log("������ �������: " + www.text); //����� ������� � www.text

        }
    }

    public IEnumerator GetUserData() //�������� ����������
    {

        CheckData();
        WWWForm form = new WWWForm(); //�������� ����� ��� ��������

        form.AddField("Login", PlayerPrefs.GetString("phone"));
        //form.AddField("Points", PlayerPrefs.GetString("points"));

        WWW www = new WWW($"{serverURL}/getData.php", form); //�������� ����� �� ������
        yield return www;

        if (www.error != null) //�������� �� ������
        {
            Debug.Log(www.error);
            yield break;
        }
        else
        {
            Debug.Log("������ �������: " + www.text); //����� ������� � www.text
            PlayerPrefs.SetInt("points", int.Parse(www.text));
        }
    }
    public void getData()
    {
        StartCoroutine(GetUserData());
    }

    void CheckData()
    {
        if(PlayerPrefs.HasKey("points")) //�������� �� ������������ ������

        {


        }
        else
        {
            PlayerPrefs.SetInt("points", 0);
        }
       
    }

}
