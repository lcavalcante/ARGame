using UnityEngine;
using System.Collections;


namespace Vuforia
{

    public class VirtualButtonEventHnadler : MonoBehaviour, IVirtualButtonEventHandler
    {

        #region PUBLIC_MEMBERS

        private bool isPlaying = false;
        private AudioSource mAudio;
        #endregion // PUBLIC_MEMBERS





        #region MONOBEHAVIOUR_METHODS
        void Start()
        {
            mAudio = this.transform.gameObject.GetComponent<AudioSource>();
            Debug.Log("Starting VB");
            // Register with the virtual buttons TrackableBehaviour
            VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
            for (int i = 0; i < vbs.Length; ++i)
            {
                vbs[i].RegisterEventHandler(this);
            }
            Debug.Log("Ending VB");
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
            mAudio.Play();
           
            //mGameObject.transform.localScale = new Vector3(2f,2f,2f);
           
        }

        /// <summary>
        /// Called when the virtual button has just been released:
        /// </summary>
        public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
        { 
            mAudio.Pause();
        }
        #endregion //PUBLIC_METHODS

    }
}
