using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject FormPause;

    public void OnEnableFormPause()
    {
        FormPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnDizableFormPause()
    {
        FormPause.SetActive(false);
        Time.timeScale = 1f;
    }
}
