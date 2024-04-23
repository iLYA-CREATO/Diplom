using TMPro;
using UnityEngine;
using YG;
public class RegisterName : MonoBehaviour
{
    public string RegisterNamePlayer;

    public void Start()
    {
        if (!YandexGame.auth)
        {
            RegisterNamePlayer = "Гость";
        }
        else
        {
            RegisterNamePlayer = YandexGame.playerName;
        }
        SaveName();
    }

    public void SaveName()
    {
        PlayerPrefs.SetString("RegisterNamePlayer", RegisterNamePlayer);
    }

}
