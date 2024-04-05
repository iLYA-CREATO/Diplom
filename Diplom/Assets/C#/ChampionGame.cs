using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class ChampionGame : MonoBehaviour
{
    public ParametrsPlayer parametrsPlayer;
    public ParametrsNPC[] parametrsNPC;
    public int NPCValue = 7; // Количество NPC

    public List<List<object>> nestedList = new List<List<object>>(); // Создаем список для хранения значений

    private bool IsAddList;// Просто флаг чтобы лист добавление в лист сработало 1 раз

    public TextMeshProUGUI[] TextName;
    public TextMeshProUGUI[] TextGem;
    // Вызывается из GemLocate
    public void WinChackChampion()
    {
        UpDataGame();
    }
    public void UpDataGame()
    {
        if (IsAddList == false)
        {
            FillData();
            LiderGame();
            
        }
    }

    public void LiderGame()
    {
        string name = null;
        int gem = 0;
        int Arr = 0;
        foreach (var innerList in nestedList)
        {
            name = innerList[0] as string;
            gem = Convert.ToInt32(innerList[1]);

            TextName[Arr].text = name;
            TextGem[Arr].text = gem.ToString();
            Arr++;
        }

        IsAddList = true;
    }
    public void FillData()
    {
        for(int i = 0; i < NPCValue;i++)
        {
            nestedList.Add(new List<object> { parametrsNPC[i].NameNPC, parametrsNPC[i].GemNPC});
        }
        nestedList.Add(new List<object> { parametrsPlayer.Name, parametrsPlayer.GemRound });
        SortByAge();

    }
    public void SortByAge()
    {
        nestedList.Sort((x, y) => ((int)y[1]).CompareTo((int)x[1]));
    }

    public void GemPlus()
    {
        PlayerPrefs.SetInt("Gem", parametrsPlayer.GemRound);
    }
}
