using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoWalk : MonoBehaviour
{

    Image imageComponent;
    public Sprite autoWalkOnImage; //Drag your first sprite here in inspector.
    public Sprite autoWalkOffImage; //Drag your second sprite here in inspector.
    void Start()
    {
        PlayerPrefs.SetInt("autoWalk", 0);
        imageComponent = GetComponent<Image>();
        imageComponent.sprite = autoWalkOffImage;
    }

    public void ToggleAutoWalk()
    {
        if (PlayerPrefs.GetInt("autoWalk") == 1)
        {
            PlayerPrefs.SetInt("autoWalk", 0);
            imageComponent.sprite = autoWalkOffImage;
        }
        else
        {
            PlayerPrefs.SetInt("autoWalk", 1);
            imageComponent.sprite = autoWalkOnImage;
        }
    }
}
