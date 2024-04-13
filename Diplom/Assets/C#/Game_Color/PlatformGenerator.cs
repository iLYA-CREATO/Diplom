using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject objectPrefab; // ������ �������, ������� �� ������ ���������
    public Transform[] spawnPoints; // ������ ��������� �������
    public List<GameObject> CubeList;

    void Start()
    {
        GenerateObjects();
    }

    public void GenerateObjects()
    {

        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject cube  = Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation);
            CubeList.Add(cube);
        }
    }
}
