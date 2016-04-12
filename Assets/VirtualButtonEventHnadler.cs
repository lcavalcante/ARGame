using UnityEngine;
using System.Collections;


namespace Vuforia
{

    public class VirtualButtonEventHnadler : MonoBehaviour, IVirtualButtonEventHandler
    {

        #region PUBLIC_MEMBERS
        /// <summary>
        /// The materials that will be set for the teapot model
        /// </summary>
        public Material m_Material;
        public Material defaultMaterial;
        public GameObject mGameObject;
        #endregion // PUBLIC_MEMBERS





        #region MONOBEHAVIOUR_METHODS
        void Start()
        {
            // Register with the virtual buttons TrackableBehaviour
            VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
            for (int i = 0; i < vbs.Length; ++i)
            {
                vbs[i].RegisterEventHandler(this);
            }
        }

        #endregion // MONOBEHAVIOUR_METHODS


        #region PUBLIC_METHODS
        /// <summary>
        /// Called when the virtual button has just been pressed:
        /// </summary>
        public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
        {
            Debug.Log("!@#$%¨&*()_!@#$%¨&*()_+");
            Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);


            mGameObject.GetComponent<Renderer>().material = m_Material;
            //mGameObject.transform.localScale = new Vector3(2f,2f,2f);
           
        }

        /// <summary>
        /// Called when the virtual button has just been released:
        /// </summary>
        public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
        {

            mGameObject.GetComponent<Renderer>().material = defaultMaterial;
            Debug.Log("Released");
        }
        #endregion //PUBLIC_METHODS

    }
}
