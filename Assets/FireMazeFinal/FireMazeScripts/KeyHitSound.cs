using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHitSound : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
