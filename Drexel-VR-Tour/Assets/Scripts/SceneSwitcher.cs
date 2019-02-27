using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    }

    public void ChangeToKitchenScene()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void ChangeToDiningRoomScene()
    {
        SceneManager.LoadScene("DiningRoom");
    }
    public void ChangeToMainBuilding()
    {
        SceneManager.LoadScene("MainBuilding");
    }

    public void ChangeToMandellTheatre()
    {
        SceneManager.LoadScene("MandellTheatre");
    }

    public void ChangeToPISB()
    {
        SceneManager.LoadScene("PISB");
    }

    public void ChangeToTheDragon()
    {
        SceneManager.LoadScene("Dragon");
    }

    public void ChangeToDAC()
    {
        SceneManager.LoadScene("DAC");
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
