using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaiseGem : MonoBehaviour
{
    public GemLocate gemLocate;
    public static event Action PlusGemRound;
    public ParametrsPlayer gemWallet;
    [SerializeField, Header("Звуки")] private Sound sound;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gem")
        {
            Debug.Log("Gem up");
            Destroy(other.gameObject);
            gemLocate.gemLocations.RemoveAll(item => item == null);
            sound.PlaySound(sound.UpGem); // Звук поднятие гема
            gemWallet.GemRound++;
            PlusGemRound!.Invoke();
        }
    }
}
