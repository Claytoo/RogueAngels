using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerArmorSystem : MonoBehaviour
{
    #region _ARMOR VAR
    [Header("Armor Component")]
    public Slider armorSlider;
    public ScriptableInteger armorScriptable;
    public ScriptableInteger maxArmorScriptable;
    #endregion

    public UnityEvent OnArmorReachZero;

    private void Start()
    {
        armorScriptable.value = maxArmorScriptable.value;
        armorSlider.maxValue = maxArmorScriptable.value;
        armorSlider.value = maxArmorScriptable.value;
    }

    private void Update()
    {
        armorSlider.value = armorScriptable.value;
    }

    public void OnHit()
    {
        armorScriptable.value = armorScriptable.value - 1 < 0 ? 0 : armorScriptable.value - 1;

        if (armorScriptable.value <= 0)
        {
            OnArmorReachZero?.Invoke();
        }
    }
}
