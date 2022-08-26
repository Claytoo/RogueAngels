using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrops : MonoBehaviour
{
   public GameObject[] items;

   public void DropItem()
   {
      Instantiate(items[Random.Range(0, items.Length)], transform.position, Quaternion.identity);
   }
}
