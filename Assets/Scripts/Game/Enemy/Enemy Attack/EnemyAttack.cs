using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;

    public GameObject projectile;
    public float cooldownTime;

    private bool isAttack;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StartCoroutine(Attack());
    }

    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    IEnumerator Attack()
    {
        Instantiate(projectile, transform.position, transform.rotation);
        yield return new WaitForSeconds(cooldownTime);
        StartCoroutine(Attack());
    }

}
