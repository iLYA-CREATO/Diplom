using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField, Header("")] private GameObject FormEndGame;
    [SerializeField, Header("")] private GameObject ButtonHome;
    [SerializeField, Header("")] private Sound sound;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0f;
            FormEndGame.SetActive(true);
            StartCoroutine(ActiveButtonHome());
        }
    }

    public IEnumerator ActiveButtonHome()
    {
        yield return new WaitForSecondsRealtime(3);
        ButtonHome.SetActive(true);
        sound.PlaySound(sound.SoudEnableButton);
    }
}
