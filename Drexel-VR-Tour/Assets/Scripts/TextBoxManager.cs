using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxManager : MonoBehaviour
{
    private GameObject textbox1;
    private GameObject textbox2;
    private AudioSource m_targetSound;
    private GameObject currentTextbox;
    private GameObject[] m_textbox = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        m_textbox[0] = GameObject.Find("Textbox1");
        m_textbox[1] = GameObject.Find("Textbox2");
        m_textbox[0].SetActive(false);
        m_textbox[1].SetActive(false);
        currentTextbox = m_textbox[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClickGneralInteractionSpot(int index)
    {
        if (m_textbox[index].activeInHierarchy)
        {
            m_textbox[index].SetActive(false);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().reloadInteractiveSound(index);
        }
        else
        {
            currentTextbox.SetActive(false);
            int length = m_textbox.Length;
            for (int i = 0; i < length; i++)
            {
                if (m_textbox[i] == currentTextbox)
                {
                    GameObject.Find("MusicPlayer").GetComponent<Audio>().reloadInteractiveSound(i);
                }
            }
            m_textbox[index].SetActive(true);
            currentTextbox = m_textbox[index];
            GameObject.Find("MusicPlayer").GetComponent<Audio>().openTextBox(index);
        }
    }

    public void onClickMainInteractionSpot(int index)
    {
        if (m_textbox[index].activeInHierarchy)
        {
            m_textbox[index].SetActive(false);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().reloadInteractiveSound(index);
        }
        else
        {
            m_textbox[index].SetActive(true);
            GameObject.Find("MusicPlayer").GetComponent<Audio>().openTextBox(index);
        }
    }
}
