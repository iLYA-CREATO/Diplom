using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public float minValue = 0f;
    public float maxValue = 1f;
    public float cycleDuration = 2f;

    private float currentTime = 0f;
    private bool increasing = true;
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= cycleDuration)
        {
            increasing = !increasing;
            currentTime = 0f;
        }

        float t = currentTime / cycleDuration;

        if (increasing)
        {
            float value = Mathf.Lerp(minValue, maxValue, t);
            // Используйте значение value для вашей логики
            transform.localScale = new Vector3(value, value, t);    
        }
        else
        {
            float value = Mathf.Lerp(maxValue, minValue, t);
            // Используйте значение value для вашей логики
            transform.localScale = new Vector3(value, value, t);
        }
    }
}
