using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject FormEndGame;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FormEndGame.SetActive(true);
        }
    }
}
