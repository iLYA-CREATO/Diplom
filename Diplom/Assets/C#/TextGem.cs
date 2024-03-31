using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextGem : MonoBehaviour
{
    [SerializeField]private ParametrsPlayer gemWallet;
    public TextMeshProUGUI TextGemRound;

    public void Start()
    {
        TextDraw();
    }
    public void OnEnable()
    {
        RaiseGem.PlusGemRound += TextDraw;
    }

    public void OnDisable()
    {
        RaiseGem.PlusGemRound -= TextDraw;
    }
    public void TextDraw()
    {
        TextGemRound.text = gemWallet.GemRound.ToString();
    }
}
