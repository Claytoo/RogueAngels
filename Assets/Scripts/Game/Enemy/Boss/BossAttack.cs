using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BossAttack : MonoBehaviour
{
    public float attackTime;
    public float transitionTime;
    public GameObject[] bossAttacks;
    public GameObject[] items;
    public Transform[] itemSpawnPoint;

    public float skill1Time;
    public float skill2Time;
    public float skill3Time;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(transitionTime - 1);
        
        ActivateSkll1();

        yield return new WaitForSeconds(skill1Time);
        
        DeactivateAllSkill();
        SpawnItem();

        yield return new WaitForSeconds(transitionTime);
        
        ActivateSkill2();

        yield return new WaitForSeconds(skill2Time);
        
        DeactivateAllSkill();
        SpawnItem();
        
        yield return new WaitForSeconds(transitionTime);
        
        
        ActivateSkill3();

        yield return new WaitForSeconds(skill3Time);
        
        DeactivateAllSkill();
        SpawnItem();

        yield return new WaitForSeconds(transitionTime);

        StartCoroutine(Attack());
    }

    void ActivateSkll1()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        bossAttacks[0].SetActive(true);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);
    }

    void ActivateSkill2()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        bossAttacks[1].SetActive(true);
        bossAttacks[0].SetActive(false);
        bossAttacks[2].SetActive(false);
    }

    void ActivateSkill3()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        bossAttacks[2].SetActive(true);
        bossAttacks[1].SetActive(false);
        bossAttacks[0].SetActive(false);
    }

    void DeactivateAllSkill()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        bossAttacks[0].SetActive(false);
        bossAttacks[1].SetActive(false);
        bossAttacks[2].SetActive(false);
    }

    void SpawnItem()
    {
        Instantiate(items[Random.Range(0, items.Length)], itemSpawnPoint[Random.Range(0, itemSpawnPoint.Length)].position, Quaternion.identity);
       
    }
}
