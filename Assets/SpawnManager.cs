using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public GameObject trashPrefab;
    //public int numberOfTrashObjects = 10;
   // public float spawnRadius = 10f;
    private float spawnRange = 9;
    void Start()
    {
        //SpawnTrash();
    }

    private Vector3 RandomPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosZ);
        return randomPos;



    }


    /*void SpawnTrash()
    {
        for (int i = 0; i < enemiesToSpaw; i++)
        {
            int randomEnemy = Random.Range(0, enemyPrefabs.Length);

            Instantiate(enemyPrefabs[randomEnemy], GenerateSpawnPostion(), enemyPrefabs[randomEnemy].transform.rotation);

        }
    }*/



}