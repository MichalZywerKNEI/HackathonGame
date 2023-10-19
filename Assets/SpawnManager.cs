using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] smieci;

    void Start()
    {
        // Pętla przez elementy tablicy i używanie Instantiate dla każdego obiektu
        foreach (GameObject smiec in smieci)
        {
            Instantiate(smiec);
        }
    }

    void Update()
    {

    }
}
