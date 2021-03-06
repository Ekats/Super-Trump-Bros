using System;
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl1 : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        Animator anim;
        int jumpHash = Animator.StringToHash("Jump");
        int runStateHash = Animator.StringToHash("Base Layer.Run");




        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump1");

            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.RightControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal1");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
