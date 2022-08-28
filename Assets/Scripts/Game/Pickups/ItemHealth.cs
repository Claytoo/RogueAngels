using UnityEngine;

public class ItemHealth : MonoBehaviour
{
    public HealthSystem healthSystem;

    public void OnGain(int gainAmmount)
    {
        if (healthSystem.useScriptable)
        {
            healthSystem.healthScriptable.value = healthSystem.healthScriptable.value + gainAmmount > healthSystem.maxHealthScriptable.value ? healthSystem.maxHealthScriptable.value : healthSystem.healthScriptable.value + gainAmmount;
        }
        else
        {
            healthSystem.health = healthSystem.health + gainAmmount > healthSystem.maxHealth ? healthSystem.maxHealth : healthSystem.health + gainAmmount;
        }
    }
}
