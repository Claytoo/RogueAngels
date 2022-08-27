using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public List<GameObject> rooms;
    public List<GameObject> enemySpawner;
    public List<DungeonTransition> roomEntrance;

    public float waitTime;
    public float bossSpawnTimeDelay;
    private bool spawnedBoss;
    public GameObject boss;

    public float bossYPosition;

    private void Start()
    {
        bossSpawnTimeDelay = 2;
    }

    private void Update()
    {
        if (waitTime <= 0 && !spawnedBoss)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count - 1)
                {
                    if (roomEntrance[i].playerEntered)
                    {
                        Destroy(enemySpawner[i]);

                        bossSpawnTimeDelay -= Time.deltaTime;

                        if (bossSpawnTimeDelay <= 0)
                        {
                            Instantiate(boss, new Vector3(rooms[i].transform.position.x, rooms[i].transform.position.y + bossYPosition), Quaternion.identity);
                            spawnedBoss = true;
                        }
                    }
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                waitTime = 0;
            }
        }
    }
}
