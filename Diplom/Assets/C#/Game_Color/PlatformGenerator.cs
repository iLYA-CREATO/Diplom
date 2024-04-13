using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject objectPrefab; // Префаб объекта, который вы хотите создавать
    public Transform[] spawnPoints; // Массив различных позиций
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
