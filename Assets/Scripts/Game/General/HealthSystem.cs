using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    #region _HEALTH VAR
    [HideInInspector] public int health;
    [HideInInspector] public ScriptableInteger healthScriptable;

    [HideInInspector] public int maxHealth;
    [HideInInspector] public ScriptableInteger maxHealthScriptable;

    [HideInInspector] public bool useScriptable;
    #endregion

    public Slider healthSlider;
    public UnityEvent OnLifeReachZero;

    private void Start()
    {
        healthSlider.maxValue = maxHealthScriptable.value;
        healthSlider.value = maxHealthScriptable.value;
    }

    private void Update()
    {
        healthSlider.value = healthScriptable.value;
    }

    public void OnHit()
    {
        if (useScriptable)
        {
            healthScriptable.value = healthScriptable.value - 1 < 0 ? 0 : healthScriptable.value -1;

            if (healthScriptable.value <= 0)
            {
                OnLifeReachZero?.Invoke();
            }
        }

        else
        {
            health = health - 1 < 0 ? 0 : health - 1;

            if (health <= 0)
            {
                OnLifeReachZero?.Invoke();
            }
        }
    }

    public void OnGain()
    {
        if (useScriptable)
        {
            healthScriptable.value = healthScriptable.value + 1 > maxHealthScriptable.value ? maxHealthScriptable.value : healthScriptable.value + 1;
        }

        else
        {
            health = health + 1 > maxHealth ? maxHealth : health + 1;
        }
    }
}
