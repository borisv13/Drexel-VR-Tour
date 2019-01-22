using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Audio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sound;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Pause_play);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause_play()
    {
        if (sound.isPlaying)
        {
            sound.Pause();
        }
        else
        {
            sound.Play();
        }
    }
}
