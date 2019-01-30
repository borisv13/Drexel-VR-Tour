using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxManager : MonoBehaviour
{
    private GameObject m_obj;

    // Start is called before the first frame update
    void Start()
    {
        m_obj = GameObject.Find("Text1");
        m_obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        if (m_obj.activeInHierarchy)
        {
            m_obj.SetActive(false);
        }
        else
        {
            m_obj.SetActive(true);
        }
    }
}
