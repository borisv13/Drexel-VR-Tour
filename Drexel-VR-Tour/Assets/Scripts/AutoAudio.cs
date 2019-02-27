using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AutoAudio : MonoBehaviour
{
    private int autoPlayAudio = 1;
    Image imageComponent;
    public Sprite autoAudiOnImage; //Drag your first sprite here in inspector.
    public Sprite autoAudioOffImage; //Drag your second sprite here in inspector.
                                    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("autoPlayAudio", autoPlayAudio);
        imageComponent = GetComponent<Image>();
        imageComponent.sprite = autoAudioOffImage;
    }
 
    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleAutoAudio()
    {
        if (autoPlayAudio == 1)
        {
            autoPlayAudio = 0;
            imageComponent.sprite = autoAudiOnImage;
        }
        else
        {
            autoPlayAudio = 1;
            imageComponent.sprite = autoAudioOffImage;
        }
        PlayerPrefs.SetInt("autoPlayAudio", autoPlayAudio);
    }

    public int getAutoPlayAudio()
    {
        return autoPlayAudio;
    }
}

