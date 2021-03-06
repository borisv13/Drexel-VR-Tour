﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Audio : MonoBehaviour
    {
        //public int mainInteractiveItemIndex;

        public AudioSource[] m_audio;
        public GameObject[] m_play;
        public GameObject[] m_pause;
        public UnityEvent switchToScene;

        private AudioSource currentSound = null;
        private int autoPlayAudio = 1;
        private int autoWalk = 0;

        //make sure main audio is the last audio
        void Start()
        {
            autoPlayAudio = PlayerPrefs.GetInt("autoPlayAudio");
            autoWalk = PlayerPrefs.GetInt("autoWalk");
            int numberOfAudio = m_audio.Length;
            currentSound = m_audio[numberOfAudio - 1];
            if (autoPlayAudio == 1)
            {
                m_play[numberOfAudio - 1].SetActive(false);
                m_pause[numberOfAudio - 1].SetActive(true);
                currentSound.Play();
            }
            else
            {
                m_play[numberOfAudio - 1].SetActive(true);
                m_pause[numberOfAudio - 1].SetActive(false);
            }
            
            
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
                if ( autoWalk == 1 && currentSound == m_audio[length - 1])
                {
                    switchToScene.Invoke();
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
    
