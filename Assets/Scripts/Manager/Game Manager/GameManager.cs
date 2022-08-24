using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region _VAR
    [Header("Player")]
    public GameObject playerPrefab;
    public float respawnTime;
    public Transform[] playerSpawnPoints;

    //[Header("Enemy")]
    //public EnemySpawner enemySpawn;

    [Header("Scriptable Object")]
    public ScriptableInteger health;
    #endregion

    public static GameManager instance;

    public UnityAction OnGameOverAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
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
