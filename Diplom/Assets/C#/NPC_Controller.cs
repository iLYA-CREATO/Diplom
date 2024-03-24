using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Controller : MonoBehaviour
{
    public GemLocate gemLocate;
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
        if (gemLocate.gemLocations.Count == 0)
        {
            Debug.LogWarning("No gem locations set");
            return;
        }
        int RandomGem = Random.Range(0, gemLocate.gemLocations.Count);
        navMeshAgent.SetDestination(gemLocate.gemLocations[RandomGem].position);

        RandomGem = (RandomGem + 1) % gemLocate.gemLocations.Count;
    }

    void RemoveDestroyedGemsFromList()
    {
        gemLocate.gemLocations.RemoveAll(item => item == null);
    }

    // Добавьте этот метод, чтобы удаление уничтоженных объектов из списка происходило в каждом кадре
    void LateUpdate()
    {
        RemoveDestroyedGemsFromList();
    }
}