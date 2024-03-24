using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemLocate : MonoBehaviour
{
    public List<Transform> gemLocations = new List<Transform>(); // ������ � ��������� ����� �� �����
    public GameObject WinPanel;
    public ChampionGame championGame;
    public void LateUpdate()
    {
        if(gemLocations.Count == 0)
        {
            championGame.WinChackChampion();
            Debug.Log("����� ����� ����");
            WinPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

