using System.Collections.Generic;
using UnityEngine;

public class GemLocate : MonoBehaviour
{
    public List<Transform> gemLocations = new List<Transform>(); // ������ � ��������� ����� �� �����
    public GameObject WinPanel;
    public ChampionGame championGame;
    public  GameObject[] gem;
    public void Awake()
    {
        Time.timeScale = 1;
            GemSerch();
    }

    private void GemSerch()
    {
        gem = GameObject.FindGameObjectsWithTag("Gem");
        for(int i = 0; i < gem.Length; i++)
        {
            gemLocations.Add(gem[i].GetComponent<Transform>());
        }
        gem = null;
    }

    bool IsWinGame = false;
    public void LateUpdate()
    {
        if (gemLocations.Count == 0)
        {
            if(IsWinGame == false)
            {
                championGame.WinChackChampion();
                Debug.Log("����� ����� ����");
                WinPanel.SetActive(true);
                Time.timeScale = 0;
                IsWinGame = true;
            }
        }
    }
}

