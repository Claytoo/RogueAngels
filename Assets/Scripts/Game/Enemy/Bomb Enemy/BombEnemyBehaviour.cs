using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
