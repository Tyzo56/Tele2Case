using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public int levelIndex;
    public GameObject Panele;
    public UIChanger UiChanger;
    
    public void SelectLevel(int index)
    {
        Panele.SetActive(false);
        UiChanger.UIUpdate();
        levelIndex = index;
        Debug.Log("Level Selected");
    } 
}
