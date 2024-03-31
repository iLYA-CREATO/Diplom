using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset;
    public float Speed;
    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * Speed); // Используем сглаживание для плавного перехода
        }
    }
}
