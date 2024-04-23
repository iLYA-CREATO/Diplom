using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource AS;

    [Header("Sound Effect"), Tooltip("�������� ������" +
        "��� ��������� ������")] 
    public AudioClip SoudEnableButton;

    [Header("Sound Effect"), Tooltip("�������� ������" +
        "������ �� ������������ ������")]
    public AudioClip SoudDestroyCube;

    [Header("Sound Effect"), Tooltip("�������� ������" +
        "�������� ����")]
    public AudioClip UpGem;

    public void PlaySound(AudioClip audioClip)
    {
        AS.PlayOneShot(audioClip);
    }
}
