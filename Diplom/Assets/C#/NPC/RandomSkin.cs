using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSkin : MonoBehaviour
{
    private int ARR;
    [SerializeField, Header("Skins: ")]private GameObject[] SkinVariant;

    private void Start()
    {
        RandomSkins();
    }

    // √енерируем рандомное число и включаем тот скин который нам попалс€
    private void RandomSkins()
    {
        ARR = Random.Range(0, SkinVariant.Length);
        SkinVariant[ARR].SetActive(true); // ¬ключаем тот что выпал
    }
}
