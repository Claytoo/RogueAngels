using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonManager : MonoBehaviour
{
    public ScriptableInteger killCount;
    public int targetKill;
    public GameObject door;

    private void Update()
    {
        if (killCount.value >= targetKill)
        {
            OpenDoor();
        }
    }

    public void CloseDoor()
    {
        door.SetActive(true);
    }

    public void OpenDoor()
    {
        door.SetActive(false);
    }
}
