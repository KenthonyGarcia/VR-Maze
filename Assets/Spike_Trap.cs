using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Trap : MonoBehaviour
{
    public Transform player;
    public Transform spawn;
    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sound.Play();
            player.transform.position = spawn.transform.position;
            Quaternion defaultRotation = spawn.rotation;
            player.transform.rotation = defaultRotation;
            Physics.SyncTransforms();
        }
    }

  
}
