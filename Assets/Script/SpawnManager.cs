using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;

    private float spawnRangeX = 14;
    private float spawnPosZ = 20;
    private float spawnSide = 25;

    private float startDelay = 2;
    private float spawnInterval = 3.5f;


    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);

        Vector3 spawnPos = new Vector3(-spawnSide, 0, Random.Range(5, 15));
        
        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.right));
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);

        Vector3 spawnPos = new Vector3(spawnSide, 0, Random.Range(5, 15));
       
        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.left));
    }


}
