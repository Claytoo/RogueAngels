using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 1f;
    private Transform targetPlayer;
    private SpriteRenderer _renderer;

    private void Awake()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (targetPlayer == null)
        {
            return;
        }
        
        Move();
        EnemyFlip();
    }

    void Move()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, targetPlayer.position, enemySpeed * Time.deltaTime);
    }

    void EnemyFlip()
    {
        if (targetPlayer.position.x > transform.position.x)
        {
            _renderer.flipX = false;
        }
        else
        {
            _renderer.flipX = true;
        }
    }
}
