using TMPro;
using UnityEngine;

public class RegisterName : MonoBehaviour
{
    public GameObject PanelRegisterName;
    public string RegisterNamePlayer;
    public TMP_InputField RegisterNameInputField;

    public void Start()
    {
       if (PlayerPrefs.HasKey("RegisterNamePlayer"))
        {
            PanelRegisterName.SetActive(false);
            RegisterNamePlayer = PlayerPrefs.GetString("RegisterNamePlayer");
        }
       else
        {
            PanelRegisterName.SetActive(true);
        }
    }

    // Регистрация
    public void InputName()
    {
        if(RegisterNameInputField.text == "")
        {
            Debug.Log("Введите имя");
        }
        else
        {
            RegisterNamePlayer = RegisterNameInputField.text;
            Debug.Log("Ваше имя: " + RegisterNamePlayer);
            PanelRegisterName.SetActive(false);
            PlayerPrefs.SetString("RegisterNamePlayer", RegisterNamePlayer);
        }
    }

    
}
