using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] smieci;
    private float SpawnRangeX = 11;
    private float SpawnRangeY = 4;


    void Start()
    {
        // Pętla przez elementy tablicy i używanie Instantiate dla każdego obiektu
        foreach (GameObject smiec in smieci)
        {
            Vector3 randomPosition = GenerateRandomPosition();
            Instantiate(smiec, randomPosition, Quaternion.identity);
        }
    }

    Vector3 GenerateRandomPosition()
    {
        float spawnX = Random.Range(-SpawnRangeX, SpawnRangeX); // Zakres dla pozycji X
        float spawnY = Random.Range(-SpawnRangeY, SpawnRangeY); // Zakres dla pozycji Z
        return new Vector3(spawnX, spawnY, 0); // Y ustawione na 0, ale można dostosować do własnych potrzeb
    }

    void Update()
    {

    }
}
