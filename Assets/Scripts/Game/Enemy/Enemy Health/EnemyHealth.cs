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
    public Slider healthSlider;

    [Header("Scriptable Value")]
    public ScriptableInteger killCount;
    public ScriptableBoolean defeatBossChecker;

    public GameObject explodsionEffect;

    public bool isBoss;

    private void Start()
    {
        currentHealth = totalHealth;
        healthSlider.maxValue = totalHealth;
        healthSlider.value = totalHealth;
    }

    private void Update()
    {
        healthSlider.value = currentHealth;
        
        if (currentHealth <= 0)
        {
            if (isBoss)
            {
                defeatBossChecker.condition = true;
                Destroy(gameObject);
                
            }
            else
            {
                killCount.value++;
                Instantiate(explodsionEffect, transform.position, Quaternion.identity);
                SoundManager.instance.PlaySound(2);
                GetComponent<ItemDrops>().DropItem();
                Destroy(gameObject);
            }
            
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }
    
}
