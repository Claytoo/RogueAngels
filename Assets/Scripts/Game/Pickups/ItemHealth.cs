using UnityEngine;

public class ItemHealth : MonoBehaviour
{
    public HealthSystem healthSystem;

    public void OnGain()
    {
        if (healthSystem.useScriptable)
        {
            healthSystem.healthScriptable.value = healthSystem.healthScriptable.value + 1 > healthSystem.maxHealthScriptable.value ? healthSystem.maxHealthScriptable.value : healthSystem.healthScriptable.value + 1;
        }
        else
        {
            healthSystem.health = healthSystem.health + 1 > healthSystem.maxHealth ? healthSystem.maxHealth : healthSystem.health + 1;
        }
    }
}
