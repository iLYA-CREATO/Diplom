using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopSkins : MonoBehaviour
{
    [Header("C#")]
    public Wallet _Wallet;

    [Header("Button")]
    public Button IsBuyButton;
    public TextMeshProUGUI TextButton;

    [Header("Текст стоимости")]
    public GameObject TextMoneyObject;
    public TextMeshProUGUI TextMoney;
    /// <summary>
    /// Помни начинаем с 0
    /// </summary>
    public int IdSkin = 0;
    public int IdSkinMax = 0;
    public int IdGetSkins;

    public GameObject[] Skins;
    [Header("Купленный персонаж")]
    public bool SkinsBuyGiryd = true;
    public bool SkinsBuyYelloStane = false;
    public bool SkinsBuyDarSoul = false;
    public bool SkinsBuyStelsWit = false;

    [Header("Выбранный персонаж")]
    public bool SkinsGetGiryd = true;
    public bool SkinsGetYelloStane = false;
    public bool SkinsGetDarSoul = false;
    public bool SkinsGetStelsWit = false;
    public List<int> MoneySkin;


    public void Start()
    {
        Skins[IdSkin].SetActive(true);
    }
    public void NextSkin()
    {
        if(IdSkin < IdSkinMax)
        {
            IdSkin++;
            Skins[IdSkin].SetActive(true);
            Skins[IdSkin - 1].SetActive(false);
        }
    }
    public void BackSkin()
    {
        if (IdSkin > 0)
        {
            IdSkin--;
            Skins[IdSkin].SetActive(true);
            Skins[IdSkin + 1].SetActive(false);
        }
    }
    //Покупка скина
    public void BuySkins()
    {
        // Основной метод покупки скина
        switch (IdSkin)
        {
            case 1: 
                if(SkinsBuyYelloStane == false)
                {
                    if (_Wallet.Gem > MoneySkin[IdSkin])
                    {
                        SkinsBuyYelloStane = true;
                        _Wallet.Gem -= MoneySkin[IdSkin];
                    }
                    else
                    {
                        Debug.Log("Нехватает на SkinsBuyYelloStane: " + (_Wallet.Gem - MoneySkin[IdSkin]));
                    }
                }
                break;

            case 2:
                if(SkinsBuyDarSoul == false)
                {
                    if (_Wallet.Gem > MoneySkin[IdSkin])
                    {
                        SkinsBuyDarSoul = true;
                        _Wallet.Gem -= MoneySkin[IdSkin];
                    }
                    else
                    {
                        Debug.Log("Нехватает на SkinsBuyDarSoul: " + (_Wallet.Gem - MoneySkin[IdSkin]));
                    }
                }
                break;
            case 3:
                if(SkinsBuyStelsWit == false)
                {
                    if (_Wallet.Gem > MoneySkin[IdSkin])
                    {
                        SkinsBuyStelsWit = true;
                        _Wallet.Gem -= MoneySkin[IdSkin];
                    }
                    else
                    {
                        Debug.Log("Нехватает на SkinsBuyStelsWit: " + (_Wallet.Gem - MoneySkin[IdSkin]));
                    }
                }
                break;
        }
    }
    //Выбор скина
    public void GetSkins()
    {
        // Основной метод выбора скина 
        switch (IdSkin)
        {
            case 0:
                SkinsGetGiryd = true;
                SkinsGetYelloStane = false;
                SkinsGetDarSoul = false;
                SkinsGetStelsWit = false;
                Debug.Log("Выбран : SkinsGetGiryd");
                break;

            case 1:
                if (SkinsBuyYelloStane == true)
                {
                    SkinsGetGiryd = false;
                    SkinsGetYelloStane = true;
                    SkinsGetDarSoul = false;
                    SkinsGetStelsWit = false;
                    Debug.Log("Выбран : SkinsGetYelloStane");
                }
                break;

            case 2:
                if (SkinsBuyDarSoul == true)
                {
                    SkinsGetGiryd = false;
                    SkinsGetYelloStane = false;
                    SkinsGetDarSoul = true;
                    SkinsGetStelsWit = false;
                    Debug.Log("Выбран : SkinsGetDarSoul");
                }
                break;

            case 3:
                if (SkinsBuyStelsWit == true)
                {
                    SkinsGetGiryd = false;
                    SkinsGetYelloStane = false;
                    SkinsGetDarSoul = false;
                    SkinsGetStelsWit = true;
                    Debug.Log("Выбран : SkinsGetStelsWit");
                }
                break;
        }
        SaveIdScin();
    }

    public void Update()
    {
        RegButtonFunk();
    }
    public void RegButtonFunk()
    {
        switch (IdSkin)
        {
            // Стартовый скин
            case 0:
                if(SkinsBuyGiryd == true) // Если куплен
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "Выбрать";
                }
                
                if (SkinsBuyGiryd == true && SkinsGetGiryd == true) // Если выбран
                {
                    TextButton.text = "Выбран";
                }
                break;
            // 2-ой скин
            case 1:
                if (SkinsBuyYelloStane == true && SkinsGetYelloStane == true) // Если выбран
                {
                    TextButton.text = "Выбран";
                }
                else if (SkinsBuyYelloStane == true) // Если куплен
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "Выбрать"; 
                }
                else if (SkinsBuyYelloStane == false) // Если не куплен
                {
                    TextMoneyObject.SetActive(true);
                    TextMoney.text = MoneySkin[IdSkin].ToString();
                    TextButton.text = "Купить";
                }
                
                break;
            // 3-тий скин
            case 2:
                if (SkinsBuyDarSoul == true && SkinsGetDarSoul == true) // Если выбран
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "Выбран";
                }
                else if (SkinsBuyDarSoul == true)
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "Выбрать";
                }
                else if (SkinsBuyDarSoul == false)// Если не куплен
                {
                    TextMoneyObject.SetActive(true);
                    TextMoney.text = MoneySkin[IdSkin].ToString();
                    TextButton.text = "Купить";
                }
                
                break;
            // 4-ый скин
            case 3:
                if (SkinsBuyStelsWit == true && SkinsGetStelsWit == true) // Если выбран
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "Выбран";
                }
                else if (SkinsBuyStelsWit == true)
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "Выбрать";
                }
                else if (SkinsBuyStelsWit == false)
                {
                    TextMoneyObject.SetActive(true);
                    TextMoney.text = MoneySkin[IdSkin].ToString();
                    TextButton.text = "Купить";
                }
                break;
        }
    }

    public void SaveIdScin()
    {
        if(SkinsGetGiryd == true)
        {
            IdGetSkins = 0;
        }
        else if(SkinsGetYelloStane == true) 
        {
            IdGetSkins = 1;
        }
        else if(SkinsGetDarSoul == true)
        {
            IdGetSkins = 2;
        }
        else if(SkinsGetStelsWit == true)
        {
            IdGetSkins = 3;
        }
        PlayerPrefs.SetInt("IdGetSkin", IdGetSkins);
    }
}
