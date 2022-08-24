using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_SpecialAttack : MonoBehaviour
{
   public float rotationSpeed = 3f;

   private void Update()
   {
      transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
   }
}
