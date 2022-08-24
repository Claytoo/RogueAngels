using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_UltimateAttack : MonoBehaviour
{
    public float attackTime;
    public float transitionTime;
    public GameObject[] lasers;

    private void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        lasers[0].SetActive(true);
        lasers[1].SetActive(false);
        lasers[2].SetActive(false);

        yield return new WaitForSeconds(attackTime);
        
        lasers[0].SetActive(false);
        lasers[1].SetActive(false);
        lasers[2].SetActive(false);

        yield return new WaitForSeconds(transitionTime);
        
        lasers[0].SetActive(false);
        lasers[1].SetActive(true);
        lasers[2].SetActive(false);
        
        yield return new WaitForSeconds(attackTime);
        
        lasers[0].SetActive(false);
        lasers[1].SetActive(false);
        lasers[2].SetActive(false);
        
        yield return new WaitForSeconds(transitionTime);
        
        lasers[0].SetActive(false);
        lasers[1].SetActive(false);
        lasers[2].SetActive(true);
        
        yield return new WaitForSeconds(attackTime);
        
        lasers[0].SetActive(false);
        lasers[1].SetActive(false);
        lasers[2].SetActive(false);
        
        yield return new WaitForSeconds(transitionTime);

        StartCoroutine(Attack());
    }
}
