using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Valve.VR;

namespace Interactive360.Utils
{
    public class LaserPointers : MonoBehaviour
    {

        public SteamVR_Behaviour_Pose pose;
        public GameObject holder;
        public GameObject pointer;
        public float thickness = 0.002f;
        public Color color;

        public event Action<RaycastHit> OnRaycasthit;                   // This event is called every frame that the user's gaze is over a collider.
        
        [SerializeField] private LayerMask m_ExclusionLayers;           // Layers to exclude from the raycast.
        [SerializeField] private bool m_ShowDebugRay;                   // Optionally show the debug ray.
        [SerializeField] private float m_DebugRayLength = 5f;           // Debug ray length.
        [SerializeField] private float m_DebugRayDuration = 1f;         // How long the Debug ray will remain visible.
        [SerializeField] private float m_RayLength = 500f;              // How far into the scene the ray is cast.


        public VRInteractiveItem m_CurrentInteractible;                //The current interactive item
        public VRInteractiveItem m_LastInteractible;                   //The last interactive item


        // Utility for other classes to get the current interactive item
        public VRInteractiveItem CurrentInteractible
        {
            get { return m_CurrentInteractible; }
        }

        private void Start()
        {

            if (pose == null)
                pose = this.GetComponent<SteamVR_Behaviour_Pose>();
            if (pose == null)
                Debug.LogError("No SteamVR_Behaviour_Pose component found on this object");

            holder = new GameObject();
            holder.transform.parent = this.transform;
            holder.transform.localPosition = Vector3.zero;
            holder.transform.localRotation = Quaternion.identity;

            pointer = GameObject.CreatePrimitive(PrimitiveType.Cube);
            pointer.transform.parent = holder.transform;
            pointer.transform.localScale = new Vector3(thickness, thickness, 100f);
            pointer.transform.localPosition = new Vector3(0f, 0f, 50f);
            pointer.transform.localRotation = Quaternion.identity;
            

            Material newMaterial = new Material(Shader.Find("Unlit/Color"));
            newMaterial.SetColor("_Color", color);
            pointer.GetComponent<MeshRenderer>().material = newMaterial;
        }

        private void Update()
        {
            EyeRaycast();
        }


        private void EyeRaycast()
        {
            // Show the debug ray if required
            if (m_ShowDebugRay)
            {
                Debug.DrawRay(this.transform.position, this.transform.forward * m_DebugRayLength, Color.blue, m_DebugRayDuration);
            }

            // Create a ray that points forwards from the camera.
            Ray ray = new Ray(this.transform.position, this.transform.forward);

            // Do the raycast forweards to see if we hit an interactive item
            if (Physics.Raycast(ray, out RaycastHit hit, m_RayLength, ~m_ExclusionLayers))
            {
                VRInteractiveItem interactible = hit.collider.GetComponent<VRInteractiveItem>(); //attempt to get the VRInteractiveItem on the hit object
                m_CurrentInteractible = interactible;

                // If we hit an interactive item and it's not the same as the last interactive item, then call Over
                if (interactible && interactible != m_LastInteractible)
                {
                    interactible.Over();
                    print(this.transform.name + "hitting");
                }
                

                // Deactive the last interactive item 
                if (interactible != m_LastInteractible)
                {
                    DeactiveLastInteractible();
                    print(this.transform.name + "hitting");
                }
                

                m_LastInteractible = interactible;


                if (OnRaycasthit != null)
                    OnRaycasthit(hit);
            }
            else
            {
                print(this.transform.name + "not hitting");
                // Nothing was hit, deactive the last interactive item.
                DeactiveLastInteractible();
                m_CurrentInteractible = null;

            }
        }


        private void DeactiveLastInteractible()
        {
            if (m_LastInteractible == null)
                return;

            m_LastInteractible.Out();
            m_LastInteractible = null;
        }


        private void HandleUp()
        {
            if (m_CurrentInteractible != null)
                m_CurrentInteractible.Up();
        }


        private void HandleDown()
        {
            if (m_CurrentInteractible != null)
                m_CurrentInteractible.Down();
        }


        private void HandleClick()
        {
            if (m_CurrentInteractible != null)
                m_CurrentInteractible.Click();
        }


        private void HandleDoubleClick()
        {
            if (m_CurrentInteractible != null)
                m_CurrentInteractible.DoubleClick();

        }
    }

}
