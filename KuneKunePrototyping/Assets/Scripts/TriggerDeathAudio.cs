using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeathAudio : MonoBehaviour
{
    public AudioClip clip;
    public float interactDelay = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(""))
        {
            Invoke("PlaySound", interactDelay);
            Debug.Log("Sound collision tirggered");

        }
    }

    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);

    }
}
