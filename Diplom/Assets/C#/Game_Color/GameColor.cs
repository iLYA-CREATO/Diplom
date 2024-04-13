using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameColor : MonoBehaviour
{
    public PlatformGenerator platformGenerator;
    public Color[] color;
    [SerializeField, Header("")] private int StartTimer;
    [Space(5)]
    [SerializeField, Header("")] private GameObject ImageColor;
    [SerializeField, Header("")] private GameObject TextTimerToColor;
    [SerializeField, Header("")] private GameObject TextTimerStartGame;
    [Space(5)]
    [SerializeField, Header("")] private Image image;
    [SerializeField, Header("")] private TextMeshProUGUI TextTimer;
    [SerializeField, Header("")] private TextMeshProUGUI TextStartTimer;
    [Space(5)]
    [SerializeField, Header("")] private int Arr;

    public static Action RegenerateColor;
    public static Action PlusGemVoln; // ��������� ����� ���� ����� �� ����

    private string[] ColorName = new string[]
    { "�������", "�����", "������", "�����",
        "����������", "�������", "���������", "�����", "������", "����������", "�����", "�������"
    };

   /* private Color[] color = new Color[]
    { "�������", "�����", "������", "�����",
        "����������", "�������", "���������", "�����", "������", "����������", "�����", "�������"
    };
*/
    public void Start()
    {
        ImageColor.SetActive(false);
        TextTimerToColor.SetActive(false);
        TextTimerStartGame.SetActive(true);

        StartCoroutine(StartGame());
    }

    // ���������� ��������� ����
    public IEnumerator StartGame()
    {
        for(int i = 5; i != 0 ; i--)
        {
            TextStartTimer.text = i.ToString(); 
            yield return new WaitForSecondsRealtime(1);
        }
        StartCoroutine(GanerateRandomColor());
    }

    // ���������� ��������� ����
    public IEnumerator GanerateRandomColor()
    {
        ImageColor.SetActive(true);
        TextTimerToColor.SetActive(true);
        TextTimerStartGame.SetActive(false);

        Arr = UnityEngine.Random.Range(0, ColorName.Length);
        ColorSettings();
        StartCoroutine(TimeDestroyCube());
        Debug.Log(ColorName[Arr]);
        yield return null;
    }

    // ����� �� ������������ �� ������ ������
    public IEnumerator TimeDestroyCube()
    {
        for(int i = 5;  i != 0 ; i--)
        {
            TextTimer.text = i.ToString();
            yield return new WaitForSecondsRealtime(1);
        }

        for(int i = 0; i < platformGenerator.CubeList.Count; i++)
        {
            
            if (platformGenerator.CubeList[i].GetComponent<CubeSettings>().ColorCube != ColorName[Arr])
            {
                platformGenerator.CubeList[i].SetActive(false);
            }
        }
        TextTimerToColor.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        StartCoroutine (TimeReload());
    }
    // ���������
    public IEnumerator TimeReload()
    {
        // �������� ��� ������
        for (int i = 0; i < platformGenerator.CubeList.Count; i++)
        {
            platformGenerator.CubeList[i].SetActive(true);
        }
        // ��������� ������ ���� �����
        RegenerateColor?.Invoke();

        ImageColor.SetActive(false);
        TextTimerToColor.SetActive(false);
        TextTimerStartGame.SetActive(true);

        // �����
        for (int i = 5; i != 0; i--)
        {
            TextStartTimer.text = i.ToString();
            yield return new WaitForSecondsRealtime(1);
        }
        PlusGemVoln?.Invoke();
        StartCoroutine(GanerateRandomColor());
        yield return null;
    }


    private void ColorSettings()
    {
        switch (ColorName[Arr])
        {
            case "�������":
                image.color = color[0];
                break;
            case "�����":
                image.color = color[1];
                break;
            case "������":
                image.color = color[2];
                break;
            case "�����":
                image.color = color[3];
                break;
            case "����������":
                image.color = color[4];
                break;
            case "�������":
                image.color = color[5];
                break;
            case "���������":
                image.color = color[6];
                break;
            case "�����":
                image.color = color[7];
                break;
            case "������":
                image.color = color[8];
                break;
            case "����������":
                image.color = color[9];
                break;
            case "�����":
                image.color = color[10];
                break;
            case "�������":
                image.color = color[11];
                break;
        }
    }
}
