using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Levels", menuName = "Quiz/New Levels")]
public class Levels : ScriptableObject
{
    public List<ScriptableObject> Level;
}
