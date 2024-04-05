using UnityEngine;
using UnityEngine.AI;

public class NPC_Controller : MonoBehaviour
{
    public GemLocate gemLocate;
    private NavMeshAgent navMeshAgent;
    public float animationThreshold = 0.1f;

    [Header("Animator")]
    public Animator animatorGiryd;
    public Animator animatorYelloStane; 
    public Animator animatorDarSoul;
    public Animator animatorStelsWit;
    float currentSpeed;
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
            Debug.Log("No gem locations set");
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

    void LateUpdate()
    {
        AnimController();
        RemoveDestroyedGemsFromList();
    }
    public void AnimController()
    {
         currentSpeed = navMeshAgent.velocity.magnitude;

        // Проверка на наличие анимации
        if (currentSpeed > animationThreshold)
        {
            if (animatorYelloStane != null)
            {
                animatorYelloStane.Play("Thyra_Run");
            }

            if (animatorGiryd != null)
            {
                animatorGiryd.Play("Thyra_Run");
            }

            if (animatorDarSoul != null)
            {
                animatorDarSoul.Play("Thyra_Run");
            }

            if (animatorStelsWit != null)
            {
                animatorStelsWit.Play("Thyra_Run");
            }
        }
        else
        {
            if (animatorYelloStane != null)
            {
                animatorYelloStane.Play("Thyra_Idle");
            }

            if (animatorGiryd != null)
            {
                animatorGiryd.Play("Thyra_Idle");// Отключить анимацию движения
            }

            if (animatorDarSoul != null)
            {
                animatorDarSoul.Play("Thyra_Idle");// Отключить анимацию движения
            }

            if (animatorStelsWit != null)
            {
                animatorStelsWit.Play("Thyra_Idle");// Отключить анимацию движения
            }
        }
    }
}