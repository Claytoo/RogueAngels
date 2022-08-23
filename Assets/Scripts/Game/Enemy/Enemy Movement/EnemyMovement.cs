using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;
    private Transform targetPlayer;

    private void Awake()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, targetPlayer.position, enemySpeed * Time.deltaTime);
    }
}
