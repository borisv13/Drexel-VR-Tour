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

    public void ChangeTo1MainBuilding()
    {
        SceneManager.LoadScene("1_MainBuilding");
    }

    public void ChangeTo2InsideMainBuilding()
    {
        SceneManager.LoadScene("2_Inside_MainBuilding");
    }
    public void ChangeTo3MainBuilding()
    {
        SceneManager.LoadScene("3_MainBuilding");
    }

    public void ChangeTo4MandellTheatre()
    {
        SceneManager.LoadScene("4_MandellTheatre");
    }

    public void ChangeTo5InsideMandellTheatre()
    {
        SceneManager.LoadScene("5_Inside_MandellTheatre");
    }

    public void ChangeTo6MandellTheatre()
    {
        SceneManager.LoadScene("6_MandellTheatre");
    }

    public void ChangeTo7PISB()
    {
        SceneManager.LoadScene("7_PISB");
    }

    public void ChangeTo8InsidePISB()
    {
        SceneManager.LoadScene("8_Inside_PISB");
    }

    public void ChangeTo9PISB()
    {
        SceneManager.LoadScene("9_PISB");
    }

    public void ChangeTo10_33rdChestnut()
    {
        SceneManager.LoadScene("10_33rd_Chestnut");
    }

    public void ChangeTo11Dragon()
    {
        SceneManager.LoadScene("11_Dragon");
    }

    public void ChangeTo12DAC()
    {
        SceneManager.LoadScene("12_DAC");
    }

    public void ChangeTo13InsideDAC()
    {
        SceneManager.LoadScene("13_Inside_DAC");
    }

    public void ChangeTo14DAC()
    {
        SceneManager.LoadScene("14_DAC");
    }

    public void ChangeTo15_33rdLancaster()
    {
        SceneManager.LoadScene("15_33rd_Lancaster");
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
