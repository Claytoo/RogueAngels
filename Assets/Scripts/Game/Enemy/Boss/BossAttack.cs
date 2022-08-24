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
        bossAttacks[0].SetActive(true);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);

        yield return new WaitForSeconds(skill1Time);
        
        bossAttacks[0].SetActive(false);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);

        yield return new WaitForSeconds(transitionTime);
        
        bossAttacks[1].SetActive(true);
        bossAttacks[0].SetActive(false);
        bossAttacks[2].SetActive(false);

        yield return new WaitForSeconds(skill2Time);
        
        bossAttacks[0].SetActive(false);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);

        yield return new WaitForSeconds(transitionTime);
        
        
        bossAttacks[2].SetActive(true);
        bossAttacks[1].SetActive(false);
        bossAttacks[0].SetActive(false);

        yield return new WaitForSeconds(skill3Time);
        
        bossAttacks[0].SetActive(false);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);

        yield return new WaitForSeconds(transitionTime);

        StartCoroutine(Attack());
    }
}
