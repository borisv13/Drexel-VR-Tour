using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserPreferences : MonoBehaviour
{
    public GameObject[] buttons;
    public Sprite autoAudioOnImage; //Drag your first sprite here in inspector.
    public Sprite autoAudioOffImage; //Drag your second sprite here in inspector.

    void Start()
    {
        ToggleAutoAudio();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleManualControl()
    {
        PlayerPrefs.SetInt("autoPlayAudio", 0);
        PlayerPrefs.SetInt("autoWalk", 0);
        buttons[0].GetComponent<Image>().sprite = autoAudioOnImage;
        buttons[1].GetComponent<Image>().sprite = autoAudioOffImage;
        buttons[2].GetComponent<Image>().sprite = autoAudioOffImage;
    }

    public void ToggleAutoAudio()
    {
        PlayerPrefs.SetInt("autoPlayAudio", 1);
        PlayerPrefs.SetInt("autoWalk", 0);
        buttons[0].GetComponent<Image>().sprite = autoAudioOffImage;
        buttons[1].GetComponent<Image>().sprite = autoAudioOnImage;
        buttons[2].GetComponent<Image>().sprite = autoAudioOffImage;
    }

    public void ToggleAutoWalk()
    {

        PlayerPrefs.SetInt("autoPlayAudio", 1);
        PlayerPrefs.SetInt("autoWalk", 1);
        buttons[0].GetComponent<Image>().sprite = autoAudioOffImage;
        buttons[1].GetComponent<Image>().sprite = autoAudioOffImage;
        buttons[2].GetComponent<Image>().sprite = autoAudioOnImage;
    }
}
