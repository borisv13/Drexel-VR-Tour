using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string previousScene;
    public string nextScene;

    void Start()
    {
    }

    public void ChangeToNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void ChangeToPreviousScene()
    {
        SceneManager.LoadScene(previousScene);
    }
}
