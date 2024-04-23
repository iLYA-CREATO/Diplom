using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField, Header("Слайдер музыки: ")] private Slider SliderMusic;
    [SerializeField, Header("Слайдер звуков: ")] private Slider SliderSound;
    
    [SerializeField, Header("Музыка: ")] private AudioSource SourceMusic;
    [SerializeField, Header("Звук: ")] private AudioSource SourceSound;

    [SerializeField, Header("Спрайт вкл/выкл музыка: ")] private Sprite[] SpriteMusic;
    [SerializeField, Header("Спрайт вкл/выкл звук: ")] private Sprite[] SpriteSound;

    [SerializeField, Header("Картинка музыка: ")] private Image ImageMusic;
    [SerializeField, Header("Картинка звук: ")] private Image ImageSound;

    public void Start()
    {
        // Выгружаем сохранения
        OutSaveAudioSattings();

        // Проверяем параметры
        ChackMusicValue();
        ChackSoundValue();
    }
    private void MusicValue()
    {
        SourceMusic.volume = SliderMusic.value / 100;

        ChackMusicValue();
    }
    private void SoundValue()
    {
        SourceSound.volume = SliderSound.value / 100;

        ChackSoundValue();
    }

    // Проверка музыки
    private void ChackMusicValue()
    {
        if (SourceMusic.volume > 0)
        {
            ImageMusic.sprite = SpriteMusic[0];// вкл
        }
        else if (SourceMusic.volume == 0)
        {
            ImageMusic.sprite = SpriteMusic[1];// выкл
        }
    }
    // Проверка звука
    private void ChackSoundValue()
    {
        if (SourceSound.volume > 0)
        {
            ImageSound.sprite = SpriteSound[0];// вкл
        }
        else if (SourceSound.volume == 0)
        {
            ImageSound.sprite = SpriteSound[1];// выкл
        }
    }

    // Сохранение настройки
    private void SaveAudioSattings()
    {
        PlayerPrefs.SetFloat("SoundValueSlider", SliderSound.value);
        PlayerPrefs.SetFloat("MusicValueSlider", SliderMusic.value );
    }

    // Выгрузка сохранения 
    private void OutSaveAudioSattings()
    {
        if (PlayerPrefs.HasKey("SoundValueSlider"))
        {
            SliderSound.value = PlayerPrefs.GetFloat("SoundValueSlider");
        }
        else
        {
            SliderSound.value = 50f;
        }

        if (PlayerPrefs.HasKey("MusicValueSlider"))
        {
            SliderMusic.value = PlayerPrefs.GetFloat("MusicValueSlider");
        }
        else
        {
            SliderMusic.value = 30f;
        }
        AcceptSettings();
    }

    // Применение настроек
    public void AcceptSettings()
    {
        MusicValue();
        SoundValue();
        SaveAudioSattings();
    }
}
