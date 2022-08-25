using UnityEngine;

public class ItemArmor : MonoBehaviour
{
    public PlayerArmorSystem playerArmor;

    public void OnGain()
    {
        playerArmor.armorScriptable.value = playerArmor.armorScriptable.value + 1 > playerArmor.maxArmorScriptable.value ? playerArmor.maxArmorScriptable.value : playerArmor.armorScriptable.value + 1;
    }
}
