using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject projectile;
    public float cooldownAttack;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        Instantiate(projectile, transform.position, transform.rotation);
        yield return new WaitForSeconds(cooldownAttack);
        StartCoroutine(Attack());
    }
}
