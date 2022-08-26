using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    #region _HEALTH VAR
    [Header("Health Component")]
    public Slider healthSlider;
    [HideInInspector] public int health;
    [HideInInspector] public ScriptableInteger healthScriptable;

    [HideInInspector] public int maxHealth;
    [HideInInspector] public ScriptableInteger maxHealthScriptable;

    [HideInInspector] public bool useScriptable;
    #endregion

    public UnityEvent OnLifeReachZero;

    public PlayerArmorSystem playerArmor;

    private void Start()
    {
        healthSlider.maxValue = maxHealthScriptable.value;
        healthSlider.value = maxHealthScriptable.value;

        playerArmor.armorSlider.maxValue = playerArmor.maxArmorScriptable.value;
        playerArmor.armorSlider.value = playerArmor.maxArmorScriptable.value;
    }

    private void Update()
    {
        healthSlider.value = healthScriptable.value;
        playerArmor.armorSlider.value = playerArmor.armorScriptable.value;
    }

    public void OnHit()
    {
        if (useScriptable)
        {
            playerArmor.armorScriptable.value = playerArmor.armorScriptable.value - 1 < 0 ? 0 : playerArmor.armorScriptable.value - 1;
            if (playerArmor.armorScriptable.value == 0)
            {
                healthScriptable.value = healthScriptable.value - 1 < 0 ? 0 : healthScriptable.value -1;
            }

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
}
