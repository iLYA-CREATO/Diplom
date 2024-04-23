using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultGame : MonoBehaviour
{
    [SerializeField, Header("")] private ColorGem colorGem;

    public GameObject Xtwo;
    public void OnEnable()
    {
        ClouseXtwoGems();
    }
    public void ClouseXtwoGems()
    {
        if(colorGem.GemColor == 0)
        {
            Xtwo.SetActive(false);
        }
    }
    public void GetGem()
    {
        int x = PlayerPrefs.GetInt("Gem");
        x += colorGem.GemColor;
        PlayerPrefs.SetInt("Gem", x);
    }

    public void XtwoGem()
    {
        int x = PlayerPrefs.GetInt("Gem");
        x += (colorGem.GemColor * 2);
        PlayerPrefs.SetInt("Gem", x);
        SceneManager.LoadScene(1); // Home
    }
}
