using System.Collections.Generic;
using UnityEngine;

public class GemLocate : MonoBehaviour
{
    public List<Transform> gemLocations = new List<Transform>(); // Список с позициями гемов на карте
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
    public void LateUpdate()
    {
        if (gemLocations.Count == 0)
        {
            championGame.WinChackChampion();
            Debug.Log("Гемов более нету");
            WinPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

