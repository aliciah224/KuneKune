using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFootsteps : MonoBehaviour
{

    public float interactDelay = 0; 
    public AudioSource footstepsSound, sprintSound;

 

   
    //If there is input from the WASD keys, sounds will play. Depending on the combination of keys either sprinting, walking or no sound is played. 
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
