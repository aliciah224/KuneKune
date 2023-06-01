using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeathAnim : MonoBehaviour
{
    public Animator animator;
    public float interactDelay = 0;

        //Runs when the player collides with the enemy

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("PlayAnimation", interactDelay);

            Debug.Log("Collision was made between enemy trigger and Player");

        }

    }

    private void PlayAnimation()
    {
        animator.SetTrigger("PlayerDeath");

    }
}
