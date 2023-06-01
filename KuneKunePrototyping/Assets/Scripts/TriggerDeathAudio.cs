using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeathAudio : MonoBehaviour
{
    public AudioClip clip;
    public float interactDelay = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Invoke("PlaySound", interactDelay);

        }
    }

    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);

    }
}
