using System;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public bool destroyByTime;
    public float destroyTime;

    private void Start()
    {
        if (destroyByTime)
        {
            Destroy(gameObject, destroyTime);
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

}
