using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEntrance : MonoBehaviour
{
    private RoomTemplates templates;

    private void Awake()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.roomEntrance.Add(GetComponent<DungeonTransition>());
    }
}
