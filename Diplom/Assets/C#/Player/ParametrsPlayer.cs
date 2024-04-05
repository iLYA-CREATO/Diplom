using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ParametrsPlayer : MonoBehaviour
{
    public string Name;
    public int GemRound;

    public void Start()
    {
        Name = PlayerPrefs.GetString("RegisterNamePlayer");
    }
}
