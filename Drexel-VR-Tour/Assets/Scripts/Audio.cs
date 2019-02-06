using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource InteractiveSound1;
    public AudioSource InteractiveSound2;

    private bool isPlay = false;
    private AudioSource currentSound = null;

    private GameObject m_textbox1_play;
    private GameObject m_textbox1_pause;

    private GameObject m_textbox2_play;
    private GameObject m_textbox2_pause;

    void Start()
    {
        InteractiveSound1.clip = (AudioClip)Resources.Load("test1", typeof(AudioClip));
        InteractiveSound2.clip = (AudioClip)Resources.Load("VikingGods", typeof(AudioClip));
        m_textbox1_play = GameObject.Find("Textbox1_play_button");
        m_textbox1_pause = GameObject.Find("Textbox1_pause_button");
        m_textbox2_play = GameObject.Find("Textbox2_play_button");
        m_textbox2_pause = GameObject.Find("Textbox2_pause_button");
        currentSound = InteractiveSound1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void onlyAudio(AudioSource targetSound)
    //{
    //    if (targetSound.isPlaying)
    //    {
    //        targetSound.Pause();
    //    }
    //    else
    //    {
    //        currentSound.Pause();
    //        m_textbox1_pause.SetActive(false);
    //        m_textbox1_play.SetActive(true);
    //        targetSound.Play();
    //        currentSound = targetSound;
    //    }
        
    //}

    public void clickTextBox2CloseButton(int type) //type0: close textbox type1: open textbox
    {
        if (type == 1)
        {
            currentSound.Pause();
            InteractiveSound1.Play();
            currentSound = InteractiveSound1;
            m_textbox2_play.SetActive(false);
            m_textbox2_pause.SetActive(true);
            m_textbox1_pause.SetActive(false);
            m_textbox1_play.SetActive(true);
        }
        else
        {
            reloadInteractiveSound(InteractiveSound1);
        }
    }

    public void clickTextBox1CloseButton(int type) //type0: close textbox type1: open textbox
    {
        if (type == 1)
        {
            currentSound.Pause();
            InteractiveSound2.Play();
            currentSound = InteractiveSound2;
            m_textbox1_play.SetActive(false);
            m_textbox1_pause.SetActive(true);
            m_textbox2_pause.SetActive(false);
            m_textbox2_play.SetActive(true);
        }
        else
        {
            reloadInteractiveSound(InteractiveSound2);
        }
    }

    public void reloadInteractiveSound(AudioSource targetSound)
    {
        targetSound.Pause();
        targetSound.time = 0;
    }

    public void PlayAndPauseTextBoxOne(AudioSource targetSound)
    {
        if (targetSound.isPlaying)
        {
            targetSound.Pause();
            m_textbox1_pause.SetActive(false);
            m_textbox1_play.SetActive(true);
        }
        else
        {
            currentSound.Pause();
            targetSound.Play();
            currentSound = targetSound;
            m_textbox1_pause.SetActive(true);
            m_textbox1_play.SetActive(false);
            m_textbox2_pause.SetActive(false);
            m_textbox2_play.SetActive(true);
        }
    }

    public void PlayAndPauseTextBoxTwo(AudioSource targetSound)
    {
        if (targetSound.isPlaying)
        {
            targetSound.Pause();
            m_textbox2_pause.SetActive(false);
            m_textbox2_play.SetActive(true);
        }
        else
        {
            currentSound.Pause();
            targetSound.Play();
            currentSound = targetSound;
            m_textbox2_pause.SetActive(true);
            m_textbox2_play.SetActive(false);
            m_textbox1_pause.SetActive(false);
            m_textbox1_play.SetActive(true);
        }
    }

    public void rewind(AudioSource targetAudioSource)
    {
        if (System.Math.Abs(targetAudioSource.time) > 10)
        {
            targetAudioSource.time = targetAudioSource.time - 10;
        }
        else
        {
            targetAudioSource.time = 0;
        }
    }

    public void forward(AudioSource targetAudioSource)
    {
        if (targetAudioSource.time < (targetAudioSource.clip.length - 10))
        {
            targetAudioSource.time += 10;
        }
        else
        {
            targetAudioSource.time = targetAudioSource.clip.length;
        }
    }
}
