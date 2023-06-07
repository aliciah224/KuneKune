using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioSource deathAudio;
    public float interactDelay = 0; 
    public AudioSource footstepsSound, sprintSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
  
            deathAudio.enabled = true;
            Debug.Log("Sound collision triggered");

        }
    }

    //private void PlaySound()
    //{
        //udioSource.PlayClipAtPoint(AudioClip, transform.position);

    //}

   

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
