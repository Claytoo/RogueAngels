using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonTransition : MonoBehaviour
{
    private Transform cam;
    public SpawnManager[] spawn;
    public ScriptableInteger killCount;
    public bool isEntrance;
    public DungeonManager dungeonManager;

    private void Start()
    {
        cam = Camera.main.transform;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            cam.position = Vector3.MoveTowards(cam.position,
                new Vector3(transform.position.x, transform.position.y, -10), 50f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player" && !isEntrance)
        {
            killCount.value = 0;
            dungeonManager.CloseDoor();
            for (int i = 0; i < spawn.Length; i++)
            {
                spawn[i].SpawnEnemies();
                
            }
        }
       
    }
}
