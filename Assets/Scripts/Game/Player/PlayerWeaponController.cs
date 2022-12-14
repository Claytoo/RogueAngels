using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public GameObject[] weaponSet;
    public GameObject[] weaponSet2;

    // Start is called before the first frame update
    void Start()
    {
        deactivateAllWeapons();
        activateWeaponSet(0);

        weaponUpgradeCheck();
    }

    private void deactivateAllWeapons()
    {
        foreach (GameObject go in weaponSet)
        {
            go.SetActive(false);
            
        }

        foreach (GameObject go in weaponSet2)
        {
            go.SetActive(false);
        }
    }

    public void activateWeaponSet(int upgradeLevel)
    {
        for (int i = 0; i < weaponSet.Length; i++)
        {
            if (i == upgradeLevel)
            {
                weaponSet[i].SetActive(true);
            }
            else
            {
                weaponSet[i].SetActive(false);
            }
        }

        for (int i = 0; i < weaponSet2.Length; i++)
        {
            if (i == upgradeLevel)
            {
                weaponSet2[i].SetActive(true);
            }
            else
            {
                weaponSet2[i].SetActive(false);
            }
        }
    }

    public void weaponUpgradeCheck()
    {
        int upgradeLevel = GetComponents<ItemBoost>().Length;

        if (upgradeLevel >= weaponSet.Length)
        {
            upgradeLevel = weaponSet.Length - 1;
        }

        if (upgradeLevel >= weaponSet2.Length)
        {
            upgradeLevel = weaponSet2.Length - 1;
        }
        activateWeaponSet(upgradeLevel);
    }
}
