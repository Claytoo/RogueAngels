using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_BasicAttack : MonoBehaviour
{
    public GameObject projectile;
    private float currentCooldown;
    public float cooldownTime = 3f;

    private void Start()
    {
        currentCooldown = cooldownTime;
    }

    private void Update()
    {
        Attack();
    }

    void Attack()
    {
        currentCooldown -= Time.deltaTime;

        if (currentCooldown <= 0)
        {
            currentCooldown = 0;
        }

        if (currentCooldown <= 0)
        {
            currentCooldown = cooldownTime;
            Instantiate(projectile, transform.position, transform.rotation);

        }
    }
}
