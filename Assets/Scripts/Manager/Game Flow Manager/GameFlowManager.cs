using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
   public GameObject dialogueSequence;
   public GameObject blackImage;
   public float startActivate;

   public PlayerController playerController;
   public PlayerAttack playerAttack;
   public PlayerMagicSphere playerMagicSphere;
   

   private void Start()
   {
      playerController.enabled = false;
      playerAttack.enabled = false;
      playerMagicSphere.enabled = false;
      
      blackImage.SetActive(true);
      Invoke("ActivateDialogueSequence", startActivate);
   }

   void ActivateDialogueSequence()
   {
      dialogueSequence.SetActive(true);
   }

   public void DeactivateDialogueSequence()
   {
      playerController.enabled = true;
      playerAttack.enabled = true;
      playerMagicSphere.enabled = true;
      
      dialogueSequence.SetActive(false);
   }
}
