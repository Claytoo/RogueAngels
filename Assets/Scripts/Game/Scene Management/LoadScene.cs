using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public float transitionTime;
    public string sceneName;
    public bool isAutoScene;

    private void Update()
    {
        if (isAutoScene) Invoke("changeScene", transitionTime);
    }

    void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneManagement(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }
}
