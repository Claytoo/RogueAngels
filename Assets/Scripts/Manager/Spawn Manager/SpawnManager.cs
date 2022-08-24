using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public void SpawnEnemies()
    {
        Invoke("spawn", 2f);
    }

    void spawn()
    {
        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], transform.position, Quaternion.identity);
    }
}
