using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpawner : MonoBehaviour
{
    private RoomTemplates templates;

    private void Awake()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.enemySpawner.Add(this.gameObject);
    }
}
