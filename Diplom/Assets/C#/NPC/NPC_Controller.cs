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
    int Arr;
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void Start()
    {
        MoveToNextItem();
    }
    void LateUpdate()
    {
        AnimController();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gem"))
        {
            MoveToNextItem();
            Destroy(other.gameObject);
            Debug.Log("Destroy");
        }
    }

    private void MoveToNextItem()
    {
        foreach (Transform item in gemLocate.gemLocations)
        {
            if (item.gameObject != null)
            {
                navMeshAgent.SetDestination(item.transform.position);
                return;
            }
        }
        // Если все предметы собраны
        navMeshAgent.SetDestination(navMeshAgent.transform.position);
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