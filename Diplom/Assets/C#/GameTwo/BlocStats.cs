using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colors
{
    Red,
    Green, 
    Blue,
    White,
    Orange
}

public class BlocStats : MonoBehaviour
{
    private Colors colors;

    
    public void Start()
    {
       
        switch (colors)
        {
            case Colors.Red:
                Debug.Log("Red");
                break;
            case Colors.Green:
                Debug.Log("Green");
                break;
            case Colors.Blue:
                Debug.Log("Blue");
                break;
            case Colors.White:
                Debug.Log("White");
                break;
            case Colors.Orange:
                Debug.Log("Orange");
                break;
        }

    }
}
