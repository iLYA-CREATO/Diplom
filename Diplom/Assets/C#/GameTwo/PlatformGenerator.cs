using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject objectPrefab; // ������ �������, ������� �� ������ ���������
    public Transform[] spawnPoints; // ������ ��������� �������

    void Start()
    {
        GenerateObjects();
    }

    public void GenerateObjects()
    {

        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
