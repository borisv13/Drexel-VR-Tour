using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rewind : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sound;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(rewind_5s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void rewind_5s()
    {
        sound.time = sound.time - 5;
    }
}
