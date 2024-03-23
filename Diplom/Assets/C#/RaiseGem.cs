using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaiseGem : MonoBehaviour
{
    public static event Action PlusGemRound;
    public GemWallet gemWallet;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gem")
        {
            Debug.Log("Gem up");
            Destroy(other.gameObject);
            gemWallet.GemRound++;
            PlusGemRound!.Invoke();
        }
    }
}
