using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forward : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sound;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Forward_5s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Forward_5s()
    {
        sound.time += 5;
    }
}
