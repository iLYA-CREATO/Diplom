using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource AS;
    public void PlaySound(AudioClip audioClip)
    {
        AS.PlayOneShot(audioClip);
    }
}
