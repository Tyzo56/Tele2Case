using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private PushNotitficationsComponent pushNotitfications;
    public void ChangeScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
    void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            pushNotitfications.SendNotification("Возвращайтесь в игру!","Ежедневные задания уже ждут вас!", DateTime.Now.AddSeconds(15),"News" );
        }
    }
}
