using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DizactivInfo : MonoBehaviour
{
    [SerializeField, Header("Открытие панели информации")] private float IsTimer;
    public void Update()
    {
        if(gameObject.activeSelf)
        {
            IsTimer += Time.deltaTime;
            if(IsTimer > 5)
            {
                gameObject.SetActive(false);
                IsTimer = 0;
            }
        }
    }
}
