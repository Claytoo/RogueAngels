using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, transform.position, transform.rotation);
            SoundManager.instance.PlaySound(0);
        }
    }
}
