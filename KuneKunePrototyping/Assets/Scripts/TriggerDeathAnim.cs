using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDeathAnim : MonoBehaviour
{
    public Animator playerAnimator;
    public GameManagerScript gameManager;


   
    //When an enemy collides with the Player movement freezes and death animation is run
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy"))
        {
            
 
            
            playerAnimator.SetTrigger("Trigger_DeathAnim");
            GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>().walkSpeed = 0;
            GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>().cameraCanMove = false;
            GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>().enableJump = false;

           
            


            gameManager.GameOver();
            Debug.Log("Dead");


        }


        

      
    }
}
