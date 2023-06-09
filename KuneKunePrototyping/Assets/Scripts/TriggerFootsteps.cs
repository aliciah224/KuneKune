using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFootsteps : MonoBehaviour
{

    
    public AudioSource footstepsSound, sprintSound;

 
    //If input from the WASD, sound will play. Depending on the combination, either sprinting, walking or no sound is played. 
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.W) || UnityEngine.Input.GetKey(KeyCode.A) || UnityEngine.Input.GetKey(KeyCode.D) || UnityEngine.Input.GetKey(KeyCode.S))
            if (UnityEngine.Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }
    }
}
