using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemyBehaviour : MonoBehaviour
{
    public ScriptableInteger killCount;
    public GameObject explosionEffect;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            killCount.value++;
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            SoundManager.instance.PlaySound(2);
            Destroy(gameObject);
        }
    }
}
