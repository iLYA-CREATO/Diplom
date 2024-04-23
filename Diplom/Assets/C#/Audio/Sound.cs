using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource AS;

    [Header("Sound Effect"), Tooltip("Звуковой эффект" +
        "при появлении кнопки")] 
    public AudioClip SoudEnableButton;

    [Header("Sound Effect"), Tooltip("Звуковой эффект" +
        "Таймер до исчезновения блоков")]
    public AudioClip SoudDestroyCube;

    [Header("Sound Effect"), Tooltip("Звуковой эффект" +
        "Поднятие гема")]
    public AudioClip UpGem;

    public void PlaySound(AudioClip audioClip)
    {
        AS.PlayOneShot(audioClip);
    }
}
