using UnityEngine;

public class ItemArmor : MonoBehaviour
{
    public PlayerArmorSystem playerArmor;

    public void OnGain(int gainAmmount)
    {
        playerArmor.armorScriptable.value = 
            playerArmor.armorScriptable.value + gainAmmount > playerArmor.maxArmorScriptable.value ? playerArmor.maxArmorScriptable.value : playerArmor.armorScriptable.value + gainAmmount;
    }
}
