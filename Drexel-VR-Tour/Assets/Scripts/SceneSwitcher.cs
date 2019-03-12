using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update

    public string previousScene;
    public string nextScene;

    void Start()
    {
    }

    public void SwitchToNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void SwitchToPreviousScene()
    {
        SceneManager.LoadScene(previousScene);
    }

}
