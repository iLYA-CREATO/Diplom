using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameColor : MonoBehaviour
{
    public PlatformGenerator platformGenerator;
    public Color[] color;
    [SerializeField, Header("Таймер до начало игры")] private int StartTimer;
    [Space(5)]
    [SerializeField, Header("Объект картинки цвета")] private GameObject ImageColor;
    [SerializeField, Header("Объект текста, таймера следующего цвета")] private GameObject TextTimerToColor;
    [SerializeField, Header("Объект текста, таймера начало игры")] private GameObject TextTimerStartGame;
    [Space(5)]
    [SerializeField, Header("Картинка")] private Image image;
    [SerializeField, Header("Текст, таймер следующего цвета")] private TextMeshProUGUI TextTimer;
    [SerializeField, Header("Текст, таймер  начало игры")] private TextMeshProUGUI TextStartTimer;
    [Space(5)]
    [SerializeField, Header("Рандомный цвет")] private int Arr;

    public static Action RegenerateColor;// Пересоздание зветов
    public static Action PlusGemVoln; // Получение гемов если игрок не упал

    [SerializeField, Header("Звуковой эффект")] private Sound sound;


    private string[] ColorName = new string[]
    { "красный", "синий", "зелёный", "жёлтый",
        "фиолетовый", "розовый", "оранжевый", "белый", "черный", "коричневый", "серый", "голубой"
    };

    public void Start()
    {
        ImageColor.SetActive(false);
        TextTimerToColor.SetActive(false);
        TextTimerStartGame.SetActive(true);

        StartCoroutine(StartGame());
    }

    // Генерируем рандомный цвет
    public IEnumerator StartGame()
    {
        for(int i = 5; i != 0 ; i--)
        {
            TextStartTimer.text = i.ToString(); 
            yield return new WaitForSecondsRealtime(1);
        }
        StartCoroutine(GanerateRandomColor());
    }

    // Генерируем рандомный цвет
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

    // Время до исчезновения не нужных блоков
    public IEnumerator TimeDestroyCube()
    {
        for(int i = 5;  i != 0 ; i--)
        {
            TextTimer.text = i.ToString();
            sound.PlaySound(sound.SoudDestroyCube);
            yield return new WaitForSeconds(1);
        }

        for(int i = 0; i < platformGenerator.CubeList.Count; i++)
        {
            
            if (platformGenerator.CubeList[i].GetComponent<CubeSettings>().ColorCube != ColorName[Arr])
            {
                platformGenerator.CubeList[i].SetActive(false);
            }
        }
        TextTimerToColor.SetActive(false);
        yield return new WaitForSeconds(3);
        StartCoroutine (TimeReload());
    }
    // Передышка
    public IEnumerator TimeReload()
    {
        // Включаем все кубики
        for (int i = 0; i < platformGenerator.CubeList.Count; i++)
        {
            platformGenerator.CubeList[i].SetActive(true);
        }
        // Изменение цветов всех кубов
        RegenerateColor?.Invoke();

        ImageColor.SetActive(false);
        TextTimerToColor.SetActive(false);
        TextTimerStartGame.SetActive(true);

        // отдых
        for (int i = 5; i != 0; i--)
        {
            TextStartTimer.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        PlusGemVoln?.Invoke();
        StartCoroutine(GanerateRandomColor());
        yield return null;
    }


    private void ColorSettings()
    {
        switch (ColorName[Arr])
        {
            case "красный":
                image.color = color[0];
                break;
            case "синий":
                image.color = color[1];
                break;
            case "зелёный":
                image.color = color[2];
                break;
            case "жёлтый":
                image.color = color[3];
                break;
            case "фиолетовый":
                image.color = color[4];
                break;
            case "розовый":
                image.color = color[5];
                break;
            case "оранжевый":
                image.color = color[6];
                break;
            case "белый":
                image.color = color[7];
                break;
            case "черный":
                image.color = color[8];
                break;
            case "коричневый":
                image.color = color[9];
                break;
            case "серый":
                image.color = color[10];
                break;
            case "голубой":
                image.color = color[11];
                break;
        }
    }
}
