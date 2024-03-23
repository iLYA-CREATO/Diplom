using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Controller : MonoBehaviour
{
    [SerializeField] private GemLocate gemLocate;
    private int currentGemIndex = 0;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        SetDestinationToNextGem();
    }

    void Update()
    {
        if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.1f)
        {
            SetDestinationToNextGem();
        }
    }

    void SetDestinationToNextGem()
    {
        if (gemLocate.gemLocations.Length == 0)
        {
            Debug.LogWarning("No gem locations set");
            return;
        }
        int RandomGem = Random.Range(0, gemLocate.gemLocations.Length);
        navMeshAgent.SetDestination(gemLocate.gemLocations[RandomGem].position);
        if(gemLocate.gemLocations[RandomGem] == null)
        {
            RandomGem = Random.Range(0, gemLocate.gemLocations.Length);
            navMeshAgent.SetDestination(gemLocate.gemLocations[RandomGem].position);
        }

        currentGemIndex = (RandomGem + 1) % gemLocate.gemLocations.Length;
    }
}
