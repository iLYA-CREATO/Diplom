using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGame : MonoBehaviour
{
    [SerializeField, Header("")] private AudioSource AudioSourceSound;
    [SerializeField, Header("")] private AudioSource AudioSourceMusic;
    private void Start()
    {
        if (PlayerPrefs.HasKey("SoundValueSlider"))
        {
            AudioSourceSound.volume = PlayerPrefs.GetFloat("SoundValueSlider") / 100;
        }
        else
        {
            AudioSourceSound.volume = 0.30f;
        }

        if (PlayerPrefs.HasKey("MusicValueSlider"))
        {
            AudioSourceMusic.volume = PlayerPrefs.GetFloat("MusicValueSlider") / 100;
        }
        else
        {
            AudioSourceMusic.volume = 0.30f;
        }
    }
}
