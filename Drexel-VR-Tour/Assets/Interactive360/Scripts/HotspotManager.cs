using UnityEngine;
using UnityEngine.UI;

namespace Interactive360
{

    //This script should be attached to an empty game object in any scene utilizing hotspots. It binds all hotspots in the scene to the scenes that they are supposed to load.
    public class HotspotManager : MonoBehaviour
    {

        public Button[] m_hotSpotsInScene; //A reference to all the hotspots in the scene that would load new scenes
        public GameObject m_playButton; //A reference to the button that toggles the video content to play
        public GameObject m_pauseButton; //A reference to the button that toggle the video content to pause

        //Toggle between showing play and pause button when once is pressed
        public void toggleButton()
        {

            m_pauseButton.SetActive(!m_pauseButton.activeInHierarchy);
            m_playButton.SetActive(!m_playButton.activeInHierarchy);

        }

    }
}   
