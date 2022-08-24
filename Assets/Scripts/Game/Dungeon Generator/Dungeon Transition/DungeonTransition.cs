using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonTransition : MonoBehaviour
{
    private Transform cam;

    private void Start()
    {
        cam = Camera.main.transform;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            // cam.position = new Vector3(transform.position.x, transform.position.y, -10);
            cam.position = Vector3.MoveTowards(cam.position,
                new Vector3(transform.position.x, transform.position.y, -10), 50f * Time.deltaTime);
        }
    }
}
