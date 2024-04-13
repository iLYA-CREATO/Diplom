using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSettings : MonoBehaviour
{
    public Color[] color;
    public string ColorCube;
    public int Arr;
    public string[] ColorName = new string[] 
    { "красный", "синий", "зелёный", "жёлтый",
        "фиолетовый", "розовый", "оранжевый", "белый", "черный", "коричневый", "серый", "голубой"
    };

    public void Start()
    {
        GenerateColor();
    }


    public void OnEnable()
    {
        GameColor.RegenerateColor += GenerateColor;
    }
    public void OnDisable()
    {
        GameColor.RegenerateColor -= GenerateColor;
    }

    public void ColorGO(string _color)
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        switch (ColorCube)
        {
            case "красный":
                renderer.material.color = color[0];
                break;
            case "синий":
                renderer.material.color = color[1];
                break;
            case "зелёный":
                renderer.material.color = color[2];
                break;
            case "жёлтый":
                renderer.material.color = color[3];
                break;
            case "фиолетовый":
                renderer.material.color = color[4];
                break;
            case "розовый":
                renderer.material.color = color[5];
                break;
            case "оранжевый":
                renderer.material.color = color[6];
                break;
            case "белый":
                renderer.material.color = color[7];
                break;
            case "черный":
                renderer.material.color = color[8];
                break;
            case "коричневый":
                renderer.material.color = color[9];
                break;
            case "серый":
                renderer.material.color = color[10];
                break;
            case "голубой":
                renderer.material.color = color[11];
                break;
        }
    }
    public void GenerateColor()
    {
        Arr = Random.Range(0, ColorName.Length);
        ColorCube = ColorName[Arr];
        ColorGO(ColorCube);
    }
}
