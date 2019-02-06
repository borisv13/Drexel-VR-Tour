using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxManager : MonoBehaviour
{
    private GameObject m_obj;
    private AudioSource m_targetSound;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Textbox1").SetActive(false);
        GameObject.Find("Textbox2").SetActive(false);;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickInteractionSpotOne(GameObject targetTextBox)
    {
        if (targetTextBox.activeInHierarchy)
        {
            targetTextBox.SetActive(false);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().clickTextBox1CloseButton(0);
            //GameObject.Find("MusicPlayer").GetComponent<Audio>().reloadInteractiveSound(GameObject.Find("Interactionspot2").GetComponent<AudioSource>());
        }
        else
        {
            targetTextBox.SetActive(true);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().clickTextBox1CloseButton(1);
        }
    }

    public void OnClickInteractionSpotTwo(GameObject targetTextBox)
    {
        if (targetTextBox.activeInHierarchy)
        {
            targetTextBox.SetActive(false);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().clickTextBox2CloseButton(0);
            //GameObject.Find("MusicPlayer").GetComponent<Audio>().reloadInteractiveSound(GameObject.Find("Interactionspot2").GetComponent<AudioSource>());
        }
        else
        {
            targetTextBox.SetActive(true);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().clickTextBox2CloseButton(1);
        }
    }
}
