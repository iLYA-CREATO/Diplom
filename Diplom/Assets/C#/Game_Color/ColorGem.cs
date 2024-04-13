using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorGem : MonoBehaviour
{
    // Те кристалы которые игрок будет получать за прохождение той или иной волны
    [SerializeField, Header("Гемы зи мини игру")] private int GemColor;
    [SerializeField, Header("Гемы зи мини игру")] private TextMeshProUGUI TextColor;
    [SerializeField, Header("Гемы зи мини игру")] private TextMeshProUGUI TextColorEndGame;

    private void Start()
    {
        TextUpdate();
    }
    private void OnEnable()
    {
        GameColor.PlusGemVoln += PlusGem;
    }

    private void OnDisable()
    {
        GameColor.PlusGemVoln -= PlusGem;
    }
    private void PlusGem()
    {
        GemColor += 10;
        TextUpdate();
    }

    private void TextUpdate()
    {
        TextColor.text = GemColor.ToString();
        TextColorEndGame.text = GemColor.ToString();
    }
}
