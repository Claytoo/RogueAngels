using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoost : MonoBehaviour
{
    public void addComponentToObject(GameObject go)
    {
        go.AddComponent<ItemBoost>();
        go.GetComponent<PlayerWeaponController>().weaponUpgradeCheck();
    }
}
