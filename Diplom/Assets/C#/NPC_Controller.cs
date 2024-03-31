using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Controller : MonoBehaviour
{
    public GemLocate gemLocate;
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
        if (gemLocate.gemLocations.Count == 0)
        {
            Debug.Log("No gem locations set");
            return;
        }
        int RandomGem = Random.Range(0, gemLocate.gemLocations.Count);
        navMeshAgent.SetDestination(gemLocate.gemLocations[RandomGem].position);
    }

    void RemoveDestroyedGemsFromList()
    {
        gemLocate.gemLocations.RemoveAll(item => item == null);
    }

  
    void LateUpdate()
    {
        RemoveDestroyedGemsFromList();
    }
}