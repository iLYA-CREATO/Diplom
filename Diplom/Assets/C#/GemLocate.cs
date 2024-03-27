using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemLocate : MonoBehaviour
{
    public List<Transform> gemLocations = new List<Transform>(); // Список с позициями гемов на карте
    public GameObject WinPanel;
    public ChampionGame championGame;
    public void Start()
    {
        Time.timeScale = 1;
    }
    public void Update()
    {
        if(gemLocations.Count == 0)
        {
            championGame.WinChackChampion();
            Debug.Log("Гемов более нету");
            WinPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

