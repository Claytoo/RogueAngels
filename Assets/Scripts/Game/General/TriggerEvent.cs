using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class TriggerEvent : MonoBehaviour
{
    public string targetTag;

    public UnityEvent OnTrigger;
    public UnityEvent<GameObject> OnTriggerWithGameobject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
#if UNITY_EDITOR
        Debug.Log("Target tag: " + targetTag + " collision tag: " + collision.tag);
#endif
        if (collision.tag == targetTag)
        {
            OnTrigger?.Invoke();
            OnTriggerWithGameobject?.Invoke(collision.gameObject);
        }
    }
}
