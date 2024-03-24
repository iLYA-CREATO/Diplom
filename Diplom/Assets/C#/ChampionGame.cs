using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChampionGame : MonoBehaviour
{
    public GemWallet WalletGemPlayer;
    public RaiseGemNPC[] RaiseGemNPC;
    public int[] WinnerGem;

    public TextMeshProUGUI[] TextGem;
    public TextMeshProUGUI[] TextName;
    public void Start()
    {
        Debug.Log("Гемы игрока: " + WalletGemPlayer.GemRound);
    }
    public void WinChackChampion()
    {
        List<int> numbersList = new List<int>();
        numbersList.Add(WalletGemPlayer.GemRound);
        for (int i = 0; i < RaiseGemNPC.Length; i++)
        {
            numbersList.Add(RaiseGemNPC[i].GemNPC);
        }
        WinnerGem = numbersList.ToArray();

        Array.Sort(WinnerGem);

        for (int i = 0; i < WinnerGem.Length; i++)
        {
            TextGem[i].text = WinnerGem[i].ToString();
        }

    }
}
