using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaiseGemNPC : MonoBehaviour
{
    public int GemNPC;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gem")
        {
            Debug.Log("NPC gem up");
            Destroy(other.gameObject);
            GemNPC++;
        }
    }
}
