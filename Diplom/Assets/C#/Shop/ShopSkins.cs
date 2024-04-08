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

    [Header("����� ���������")]
    public GameObject TextMoneyObject;
    public TextMeshProUGUI TextMoney;
    /// <summary>
    /// ����� �������� � 0
    /// </summary>
    public int IdSkin = 0;
    public int IdSkinMax = 0;
    public int IdGetSkins;

    public GameObject[] Skins;
    [Header("��������� ��������")]
    public bool SkinsBuyGiryd = true;
    public bool SkinsBuyYelloStane = false;
    public bool SkinsBuyDarSoul = false;
    public bool SkinsBuyStelsWit = false;

    [Header("��������� ��������")]
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
    //������� �����
    public void BuySkins()
    {
        // �������� ����� ������� �����
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
                        Debug.Log("��������� �� SkinsBuyYelloStane: " + (_Wallet.Gem - MoneySkin[IdSkin]));
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
                        Debug.Log("��������� �� SkinsBuyDarSoul: " + (_Wallet.Gem - MoneySkin[IdSkin]));
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
                        Debug.Log("��������� �� SkinsBuyStelsWit: " + (_Wallet.Gem - MoneySkin[IdSkin]));
                    }
                }
                break;
        }
    }
    //����� �����
    public void GetSkins()
    {
        // �������� ����� ������ ����� 
        switch (IdSkin)
        {
            case 0:
                SkinsGetGiryd = true;
                SkinsGetYelloStane = false;
                SkinsGetDarSoul = false;
                SkinsGetStelsWit = false;
                Debug.Log("������ : SkinsGetGiryd");
                break;

            case 1:
                if (SkinsBuyYelloStane == true)
                {
                    SkinsGetGiryd = false;
                    SkinsGetYelloStane = true;
                    SkinsGetDarSoul = false;
                    SkinsGetStelsWit = false;
                    Debug.Log("������ : SkinsGetYelloStane");
                }
                break;

            case 2:
                if (SkinsBuyDarSoul == true)
                {
                    SkinsGetGiryd = false;
                    SkinsGetYelloStane = false;
                    SkinsGetDarSoul = true;
                    SkinsGetStelsWit = false;
                    Debug.Log("������ : SkinsGetDarSoul");
                }
                break;

            case 3:
                if (SkinsBuyStelsWit == true)
                {
                    SkinsGetGiryd = false;
                    SkinsGetYelloStane = false;
                    SkinsGetDarSoul = false;
                    SkinsGetStelsWit = true;
                    Debug.Log("������ : SkinsGetStelsWit");
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
            // ��������� ����
            case 0:
                if(SkinsBuyGiryd == true) // ���� ������
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "�������";
                }
                
                if (SkinsBuyGiryd == true && SkinsGetGiryd == true) // ���� ������
                {
                    TextButton.text = "������";
                }
                break;
            // 2-�� ����
            case 1:
                if (SkinsBuyYelloStane == true && SkinsGetYelloStane == true) // ���� ������
                {
                    TextButton.text = "������";
                }
                else if (SkinsBuyYelloStane == true) // ���� ������
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "�������"; 
                }
                else if (SkinsBuyYelloStane == false) // ���� �� ������
                {
                    TextMoneyObject.SetActive(true);
                    TextMoney.text = MoneySkin[IdSkin].ToString();
                    TextButton.text = "������";
                }
                
                break;
            // 3-��� ����
            case 2:
                if (SkinsBuyDarSoul == true && SkinsGetDarSoul == true) // ���� ������
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "������";
                }
                else if (SkinsBuyDarSoul == true)
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "�������";
                }
                else if (SkinsBuyDarSoul == false)// ���� �� ������
                {
                    TextMoneyObject.SetActive(true);
                    TextMoney.text = MoneySkin[IdSkin].ToString();
                    TextButton.text = "������";
                }
                
                break;
            // 4-�� ����
            case 3:
                if (SkinsBuyStelsWit == true && SkinsGetStelsWit == true) // ���� ������
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "������";
                }
                else if (SkinsBuyStelsWit == true)
                {
                    TextMoneyObject.SetActive(false);
                    TextButton.text = "�������";
                }
                else if (SkinsBuyStelsWit == false)
                {
                    TextMoneyObject.SetActive(true);
                    TextMoney.text = MoneySkin[IdSkin].ToString();
                    TextButton.text = "������";
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
