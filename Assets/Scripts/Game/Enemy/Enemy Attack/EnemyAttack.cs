using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject projectile;
    public float cooldownAttack;

    public bool soundCenter;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(cooldownAttack);
        Instantiate(projectile, transform.position, transform.rotation);

        if (soundCenter)
        {
            SoundManager.instance.PlaySound(3);
        }
        
        yield return new WaitForSeconds(cooldownAttack);
        StartCoroutine(Attack());
    }
}
