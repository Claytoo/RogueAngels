using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Spawn Point" && col.GetComponent<RoomSpawner>().spawned)
        {
            Destroy(gameObject);
        }
    }
}
