using System;
using Unity.Notifications.Android;
using UnityEngine;

public class PushNotitficationsComponent : MonoBehaviour
{
    private void Awake()
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel() //Создаю канал уведомлений(категорию)
        {
            Name = "Notification",
            Description = "Default message",
            Importance = Importance.High,
            Id = "News",
        };
        
        AndroidNotificationCenter.RegisterNotificationChannel(channel); //Регистрирую его
        
        Debug.Log("channel created");
    } 

    public void SendNotification(string title, string body, DateTime time, string channelId) // Отправка уведомлений
    {
        AndroidNotification notification = new AndroidNotification() //Создаю уведомления
        {
            Title = title,
            Text = body,
            FireTime = time,
        };

        AndroidNotificationCenter.SendNotification(notification, channelId); //Отправляю его
        
        Debug.Log("notification created");
    }
}