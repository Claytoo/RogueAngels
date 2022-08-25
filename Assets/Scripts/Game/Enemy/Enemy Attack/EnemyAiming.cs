using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiming : MonoBehaviour
{
    private Transform player;
    private Rigidbody2D rb;
    

    private bool isAttack;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player == null)
        {
            return;
        }
        
        if (Vector3.Distance(transform.position, player.position) < 10)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            Debug.Log("Player In Range");
        }
        
        
    }

}
