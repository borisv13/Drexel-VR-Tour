using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAudio : MonoBehaviour
{
    public GameObject closeAutoAudio;
    public GameObject openAutoAudio;
    private int autoPlayAudio = 1;
        // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("autoPlayAudio", autoPlayAudio);
        closeAutoAudio.SetActive(true);
        openAutoAudio.SetActive(false);
    }
 
    // Update is called once per frame
    void Update()
    {

    }

    public void clickButton()
    {
        if (autoPlayAudio == 1)
        {
            autoPlayAudio = 0;
            closeAutoAudio.SetActive(false);
            openAutoAudio.SetActive(true);
        }
        else
        {
            autoPlayAudio = 1;
            closeAutoAudio.SetActive(true);
            openAutoAudio.SetActive(false);
        }
        PlayerPrefs.SetInt("autoPlayAudio", autoPlayAudio);
    }

    public int getAutoPlayAudio()
    {
        return autoPlayAudio;
    }
}

