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
}
