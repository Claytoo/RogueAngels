using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Players")]
    public GameObject playerPrefab;
    public float respawnTime;

    [Header("Spawner")]
    public Transform[] playerSpawnPoints;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SpawnPlayer();
    }

    internal void SpawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPoints[Random.Range(0, playerSpawnPoints.Length)].position, Quaternion.identity);
    }
}
