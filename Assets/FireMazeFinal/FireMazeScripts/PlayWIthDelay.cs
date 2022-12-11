using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWIthDelay : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay;

    public void PlayDelay()
    {
        StartCoroutine(PlaySoundAfterDelay(delay));
    }

    IEnumerator PlaySoundAfterDelay(float del)
    {
        yield return new WaitForSeconds(del);
        audioSource.Play();
    }
}
