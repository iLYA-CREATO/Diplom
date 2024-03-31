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

    // �����������
    public void InputName()
    {
        if(RegisterNameInputField.text == "")
        {
            Debug.Log("������� ���");
        }
        else
        {
            RegisterNamePlayer = RegisterNameInputField.text;
            Debug.Log("���� ���: " + RegisterNamePlayer);
            PanelRegisterName.SetActive(false);
            PlayerPrefs.SetString("RegisterNamePlayer", RegisterNamePlayer);
        }
    }

    
}
