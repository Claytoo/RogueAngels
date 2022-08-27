using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowManager : MonoBehaviour
{
   public GameObject dialogueSequence;
   public GameObject blackImage;
   public GameObject pausePanel;
   public GameObject winPanel;
   public GameObject losePanel;
   public float startActivate;

   public PlayerMovement playerMovement;
   public PlayerController playerController;
   public PlayerAttack[] playerAttack;
   public PlayerMagicSphere playerMagicSphere;

   public ScriptableInteger health;
   public ScriptableInteger armor;

   public ScriptableBoolean bossDefeated;

   private void Start()
   {
      Time.timeScale = 1;
      bossDefeated.condition = false;
      DeactivatePlayerComponent();
      
      blackImage.SetActive(true);
      
      Invoke("ActivateDialogueSequence", startActivate);

      health.ResetValue();
      armor.ResetValue();
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
         PauseGame();
      }
      checkBoss();
   }

   void ActivateDialogueSequence()
   {
      dialogueSequence.SetActive(true);
   }

   public void DeactivateDialogueSequence()
   {
      ActivatePlayerComponent();
      
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

   void checkBoss()
   {
      if (bossDefeated.condition)
      {
         winPanel.SetActive(true);
         DeactivatePlayerComponent();
      }
   }

   void ActivatePlayerComponent()
   {
      playerMovement.enabled = true;
      playerController.enabled = true;
      for (int i = 0; i < playerAttack.Length; i++)
      {
         playerAttack[i].enabled = true;
      }
      
      playerMagicSphere.enabled = true;
   }

   void DeactivatePlayerComponent()
   {
      playerMovement.enabled = false;
      playerController.enabled = false;
      for (int i = 0; i < playerAttack.Length; i++)
      {
         playerAttack[i].enabled = false;
      }
      playerMagicSphere.enabled = false;
   }

    public void LoseCondition()
    {
        losePanel.SetActive(true);
        DeactivatePlayerComponent();
    }
}
