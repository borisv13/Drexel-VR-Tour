using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource InteractiveSound1;
    public AudioSource InteractiveSound2;
    public AudioSource mainInteractiveSound;
    public int mainInteractiveItemIndex;

    private AudioSource currentSound = null;

    private AudioSource[] m_audio = new AudioSource[3];
    private GameObject[] m_play = new GameObject[3];
    private GameObject[] m_pause = new GameObject[3];

    void Start()
    {
        m_audio[0] = InteractiveSound1;
        m_audio[1] = InteractiveSound2;
        m_audio[2] = mainInteractiveSound;
        m_play[0] = GameObject.Find("Textbox2_play_button");
        m_pause[0] = GameObject.Find("Textbox2_pause_button");
        m_play[1] = GameObject.Find("Textbox1_play_button");
        m_pause[1] = GameObject.Find("Textbox1_pause_button");
        m_play[2] = GameObject.Find("Textbox3_play_button");
        m_pause[2] = GameObject.Find("Textbox3_pause_button");
        currentSound = mainInteractiveSound;
        m_play[mainInteractiveItemIndex].SetActive(false);
        m_pause[mainInteractiveItemIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!currentSound.isPlaying)
        {
            if (currentSound.time == currentSound.clip.length)
            {
                int length = m_audio.Length;
                for (int i = 0; i < length; i++)
                {
                    if (m_audio[i] == currentSound)
                    {
                        m_audio[i].Pause();
                        m_audio[i].time = 0;
                        m_play[i].SetActive(true);
                        m_pause[i].SetActive(false);
                    }
                }
            }
        }
    }


    public void openTextBox(int index)
    {
        int length = m_audio.Length;
        for (int i = 0; i < length; i++)
        {
            if (index == i)
            {
                currentSound.Pause();
                m_audio[i].Play();
                currentSound = m_audio[i];
                m_play[i].SetActive(false);
                m_pause[i].SetActive(true);
            }
            else
            {
                m_play[i].SetActive(true);
                m_pause[i].SetActive(false);
            }
        }
    }

    public void reloadInteractiveSound(int index)
    {
        m_audio[index].Pause();
        m_audio[index].time = 0;
    }

    public void PlayAndPauseTextBox(int index)
    {
        if (m_audio[index].isPlaying)
        {
            m_audio[index].Pause();
            m_play[index].SetActive(true);
            m_pause[index].SetActive(false);
        }
        else
        {
            int length = m_audio.Length;
            for (int i = 0; i < length; i++)
            {
                if (index == i)
                {
                    currentSound.Pause();
                    m_audio[i].Play();
                    currentSound = m_audio[i];
                    m_play[i].SetActive(false);
                    m_pause[i].SetActive(true);
                }
                else
                {
                    m_play[i].SetActive(true);
                    m_pause[i].SetActive(false);
                }
            }
        }
    }

    public void rewind(int index)
    {
        if (System.Math.Abs(m_audio[index].time) > 10)
        {
            m_audio[index].time = m_audio[index].time - 10;
        }
        else
        {
            m_audio[index].time = 0;
        }
    }

    public void forward(int index)
    {
        if (m_audio[index].time < (m_audio[index].clip.length - 10))
        {
            m_audio[index].time += 10;
            //m_audio[index].time = m_audio[index].clip.length - 10;
        }
        else
        {
            m_audio[index].time = m_audio[index].clip.length;
        }
    }

}
