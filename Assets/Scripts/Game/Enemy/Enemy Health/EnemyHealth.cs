using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [Header("Health Value")]
    public float totalHealth;
    public float currentHealth;

    [Header("UI Slider")] 
    public Vector3 offset;
    public Slider healthSlider;

    private void Start()
    {
        currentHealth = totalHealth;
        healthSlider.maxValue = totalHealth;
        healthSlider.value = totalHealth;
    }

    private void Update()
    {
        // healthSlider.transform.position = Camera.main.WorldToScreenPoint(transform.position + offset);
        healthSlider.value = currentHealth;
        
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }
    
}
