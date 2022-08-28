using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_UltimateAttack : MonoBehaviour
{
    public float waitTime;
    public float attackTime;
    public float transitionTime;
    public GameObject[] lasers;
    public GameObject[] lasersTrajectory;

    // private void Start()
    // {
    //     StartCoroutine(Attack());
    // }

    // private void OnTriggerStay2D(Collider2D other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         StartCoroutine(Attack());
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        //activate laser 1
        ActivateLaser1Trajectory();
        yield return new WaitForSeconds(waitTime);
        ActivateLaser1();
        yield return new WaitForSeconds(attackTime);
        
        DeactivateAllLaser();
        yield return new WaitForSeconds(transitionTime);
        
        //activate laser 2
        ActivateLaser2Trajectory();
        yield return new WaitForSeconds(waitTime);
        ActivateLaser2();
        yield return new WaitForSeconds(attackTime);
        
        DeactivateAllLaser();
        yield return new WaitForSeconds(transitionTime);
        
        //activate laser 3
        ActivateLaser3Trajectory();
        yield return new WaitForSeconds(waitTime);
        ActivateLaser3();
        yield return new WaitForSeconds(attackTime);
        
        DeactivateAllLaser();
        yield return new WaitForSeconds(transitionTime);

        StartCoroutine(Attack());
    }

    void ActivateLaser1()
    {
        SoundManager.instance.PlaySound(1);
        lasers[0].SetActive(true);
        lasers[1].SetActive(false);
        lasers[2].SetActive(false);
    }

    void ActivateLaser1Trajectory()
    {
        lasersTrajectory[0].SetActive(true);
        lasersTrajectory[1].SetActive(false);
        lasersTrajectory[2].SetActive(false);
    }

    void ActivateLaser2()
    {
        SoundManager.instance.PlaySound(1);
        lasers[0].SetActive(false);
        lasers[1].SetActive(true);
        lasers[2].SetActive(false);
    }
    
    void ActivateLaser2Trajectory()
    {
        lasersTrajectory[0].SetActive(false);
        lasersTrajectory[1].SetActive(true);
        lasersTrajectory[2].SetActive(false);
    }

    void ActivateLaser3()
    {
        SoundManager.instance.PlaySound(1);
        lasers[0].SetActive(false);
        lasers[1].SetActive(false);
        lasers[2].SetActive(true);
    }
    
    void ActivateLaser3Trajectory()
    {
        lasersTrajectory[0].SetActive(false);
        lasersTrajectory[1].SetActive(false);
        lasersTrajectory[2].SetActive(true);
    }

    void DeactivateAllLaser()
    {
        lasers[0].SetActive(false);
        lasers[1].SetActive(false);
        lasers[2].SetActive(false);
        
        lasersTrajectory[0].SetActive(false);
        lasersTrajectory[1].SetActive(false);
        lasersTrajectory[2].SetActive(false);
    }
}
