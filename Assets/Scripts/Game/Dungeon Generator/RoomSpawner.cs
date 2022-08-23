using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawner : MonoBehaviour
{
  public enum SpawnDirection
  {
    top,
    bottom,
    right,
    left,
    nullRoom
  }
  public SpawnDirection spawnDirection;
  private RoomTemplates templates;
  private bool spawned;

  public float waitTime = 4f;

  private void Start()
  {
    Destroy(gameObject, waitTime);
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    Invoke("SpawnRoom", 0.1f);
  }

  private void SpawnRoom()
  {
    if (!spawned)
    {
      if (spawnDirection == SpawnDirection.bottom)
      {
        Instantiate(templates.bottomRooms[Random.Range(0, templates.bottomRooms.Length)], transform.position,
          Quaternion.identity);
      }
      else if (spawnDirection == SpawnDirection.top)
      {
        Instantiate(templates.topRooms[Random.Range(0, templates.topRooms.Length)], transform.position,
          Quaternion.identity);
      }
      else if (spawnDirection == SpawnDirection.left)
      {
        Instantiate(templates.leftRooms[Random.Range(0, templates.leftRooms.Length)], transform.position,
          Quaternion.identity);
      }
      else if (spawnDirection == SpawnDirection.right)
      {
        Instantiate(templates.rightRooms[Random.Range(0, templates.rightRooms.Length)], transform.position,
          Quaternion.identity);
      }
    }

    spawned = true;
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.CompareTag("Spawn Point"))
    {
      if (col.GetComponent<RoomSpawner>().spawned == false && spawned == false)
      {
        Instantiate(templates.closedRooms, transform.position, Quaternion.identity);
        Destroy(gameObject);
      }
      spawned = true;
    }
  }
}
