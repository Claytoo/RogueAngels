using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public float destroyTime = 15f;

    public GameObject explosionEffect;
    
    public enum BulletFor
    {
        Player,
        Enemy
    }

    public BulletFor bulletFor;

    private void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (bulletFor == BulletFor.Enemy)
        {
            if (col.tag == "Player")
            {
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
        else if (bulletFor == BulletFor.Player)
        {
            if (col.tag == "Enemy" || col.tag == "LaserBeam")
            {
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
