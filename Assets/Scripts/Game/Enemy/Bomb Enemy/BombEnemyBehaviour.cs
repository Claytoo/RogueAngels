using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemyBehaviour : MonoBehaviour
{
    public ScriptableInteger killCount;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            killCount.value++;
            Destroy(gameObject);
        }
    }
}
