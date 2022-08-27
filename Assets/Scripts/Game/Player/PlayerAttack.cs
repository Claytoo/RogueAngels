using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
            SoundManager.instance.PlaySound(0);
        }
    }
}
