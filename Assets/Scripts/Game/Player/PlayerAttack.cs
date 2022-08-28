using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;
    public bool soundCenter;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (soundCenter)
            {
                SoundManager.instance.PlaySound(0);
            }
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
