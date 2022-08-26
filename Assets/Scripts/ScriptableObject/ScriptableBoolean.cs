using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Booelan", menuName = "Scriptable Bool")]

public class ScriptableBoolean : ScriptableObject
{
   public bool condition;
   public bool resetOnEnable;

   private void OnEnable()
   {
      if (resetOnEnable)
      {
         condition = false;
      }
   }
}
