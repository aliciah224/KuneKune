using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Script_DeathAnim : MonoBehaviour
{
    public Animator playerAnimator;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            playerAnimator.SetTrigger("Trigger_DeathAnim");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy"))
        {
            playerAnimator.SetTrigger("Trigger_DeathAnim");
            GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>().walkSpeed = 0;
            GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>().cameraCanMove = false;
            GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>().enableJump = false;

        }

      
    }
}
