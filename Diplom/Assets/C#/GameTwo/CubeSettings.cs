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
public class CubeSettings : MonoBehaviour
{
    public Color[] color;
    public Colors colors;
    public string ColorCube;
    public int Arr;
    public string[] ColorName = new string[] { "�������", "�����", "������", "�����",
        "����������", "�������", "���������", "�����", "������", "����������", "�����", "�������"};

    public void Start()
    {
        GenerateColor();
        ColorGO();
    }

    public void ColorGO()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        switch (ColorCube)
        {
            case "�������":
                renderer.material.color = color[0];
                break;
            case "�����":
                renderer.material.color = color[1];
                break;
            case "������":
                renderer.material.color = color[2];
                break;
            case "�����":
                renderer.material.color = color[3];
                break;
            case "����������":
                renderer.material.color = color[4];
                break;
            case "�������":
                renderer.material.color = color[5];
                break;
            case "���������":
                renderer.material.color = color[6];
                break;
            case "�����":
                renderer.material.color = color[7];
                break;
            case "������":
                renderer.material.color = color[8];
                break;
            case "����������":
                renderer.material.color = color[9];
                break;
            case "�����":
                renderer.material.color = color[10];
                break;
            case "�������":
                renderer.material.color = color[11];
                break;
        }
    }
    public void GenerateColor()
    {
        Arr = Random.Range(0, ColorName.Length);
        ColorCube = ColorName[Arr];
    }
}
