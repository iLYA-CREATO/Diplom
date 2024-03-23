using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform target; // Ссылка на игрока, за которым будет следить камера
    public Vector3 offset; // Смещение камеры относительно игрока

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5); // Используем сглаживание для плавного перехода
        }
    }
}
