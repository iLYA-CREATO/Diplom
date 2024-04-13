using TMPro;
using UnityEngine;

public class RegisterName : MonoBehaviour
{
    [SerializeField] private GameObject RegisterForm;
    [SerializeField] private GameObject MenuForm;
    public string RegisterNamePlayer;
    public TMP_InputField RegisterNameInputField;

    public void Start()
    {
       if (PlayerPrefs.HasKey("RegisterNamePlayer"))
        {
            RegisterForm.SetActive(false);
            MenuForm.SetActive(true);
            RegisterNamePlayer = PlayerPrefs.GetString("RegisterNamePlayer");
        }
       else
        {
            RegisterForm.SetActive(true);
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
            RegisterForm.SetActive(false);
            MenuForm.SetActive(true);
            PlayerPrefs.SetString("RegisterNamePlayer", RegisterNamePlayer);
        }
    }

    
}
