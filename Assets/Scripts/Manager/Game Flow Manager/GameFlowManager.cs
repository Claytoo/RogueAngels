using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowManager : MonoBehaviour
{
   public GameObject dialogueSequence;
   public GameObject blackImage;
   public GameObject pausePanel;
   public float startActivate;

   public PlayerMovement playerMovement;
   public PlayerController playerController;
   public PlayerAttack playerAttack;
   public PlayerMagicSphere playerMagicSphere;
   

   private void Start()
   {
      Time.timeScale = 1;
      
      playerMovement.enabled = false;
      playerController.enabled = false;
      playerAttack.enabled = false;
      playerMagicSphere.enabled = false;
      
      blackImage.SetActive(true);
      Invoke("ActivateDialogueSequence", startActivate);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
         PauseGame();
      }
   }

   void ActivateDialogueSequence()
   {
      dialogueSequence.SetActive(true);
   }

   public void DeactivateDialogueSequence()
   {
      playerMovement.enabled = true;
      playerController.enabled = true;
      playerAttack.enabled = true;
      playerMagicSphere.enabled = true;
      
      dialogueSequence.SetActive(false);
   }

   void PauseGame()
   {
      Time.timeScale = 0;
      pausePanel.SetActive(true);
   }

   public void ResumeGame()
   {
      Time.timeScale = 1;
      pausePanel.SetActive(false);
   }

   public void changeScene(string targetScene)
   {
      SceneManager.LoadScene(targetScene);
   }
}
