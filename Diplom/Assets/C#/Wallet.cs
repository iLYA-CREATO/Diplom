using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int Gem;
    public TextMeshProUGUI TextGem;
    public void Start()
    {
        Gem = PlayerPrefs.GetInt("Gem");
        TextGem.text = Gem.ToString();
    }

    public void OutText()
    {
        TextGem.text = Gem.ToString();
    }

    public void plusGem()
    {
        Gem += 100;
        TextGem.text = Gem.ToString();
    }
}
