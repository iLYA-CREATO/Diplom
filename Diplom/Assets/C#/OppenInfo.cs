using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class OppenInfo : MonoBehaviour
{
    [SerializeField, Header("�������� ������ ����������")] private bool IsOppen;
    public void OpenInfo(GameObject Window)
    {
        IsOppen = !IsOppen;
        Window.SetActive(IsOppen);
    }
}
