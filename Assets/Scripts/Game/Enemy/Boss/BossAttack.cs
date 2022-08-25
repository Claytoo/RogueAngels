using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public float attackTime;
    public float transitionTime;
    public GameObject[] bossAttacks;

    public float skill1Time;
    public float skill2Time;
    public float skill3Time;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        ActivateSkll1();

        yield return new WaitForSeconds(skill1Time);
        
        DeactivateAllSkill();

        yield return new WaitForSeconds(transitionTime);
        
        ActivateSkill2();

        yield return new WaitForSeconds(skill2Time);
        
        DeactivateAllSkill();
        
        yield return new WaitForSeconds(transitionTime);
        
        
        ActivateSkill3();

        yield return new WaitForSeconds(skill3Time);
        
        DeactivateAllSkill();

        yield return new WaitForSeconds(transitionTime);

        StartCoroutine(Attack());
    }

    void ActivateSkll1()
    {
        bossAttacks[0].SetActive(true);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);
    }

    void ActivateSkill2()
    {
        bossAttacks[1].SetActive(true);
        bossAttacks[0].SetActive(false);
        bossAttacks[2].SetActive(false);
    }

    void ActivateSkill3()
    {
        bossAttacks[2].SetActive(true);
        bossAttacks[1].SetActive(false);
        bossAttacks[0].SetActive(false);
    }

    void DeactivateAllSkill()
    {
        bossAttacks[0].SetActive(false);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);
    }
}
