using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabsArray;
    private int animalIndex;

    private float spawnRangeX = 15f;
    private float spawnPosZ = 20f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;


    private void Start() 
    {
        InvokeRepeating(methodName:"SpawnRandomAnimal", 
            time:startDelay, repeatRate:spawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabsArray.Length);
        Instantiate(animalPrefabsArray[animalIndex]);
           RandomSpawnPos();
           Quaternion.Euler(0, 180, 0);
    }

   private Vector3 RandomSpawnPos() 
   { 
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return Vector3.zero;
   }


}
