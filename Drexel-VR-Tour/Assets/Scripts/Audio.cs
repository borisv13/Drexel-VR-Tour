using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Sound;

    private bool isPlay = false;

    void Start()
    {
        Sound.clip = (AudioClip)Resources.Load("test1", typeof(AudioClip));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayAndPause()
    {
        if (isPlay == false)
        {
            Sound.Play();
            isPlay = true;
        }
        else
        {
            Sound.Pause();
            isPlay = false;
        }
    }
}
