using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySkins : MonoBehaviour
{
    [SerializeField, Header("�����: ")]private GameObject[] skins;
    [SerializeField, Header("����� �����: ")] private int IdSkin;

    public void OnEnable()
    {
        IdSkin = PlayerPrefs.GetInt("IdGetSkin");
        for(int i = 0; i < skins.Length; i++)
        {
            skins[i].SetActive(false);
        }
        skins[IdSkin].SetActive(true);
    }
}
