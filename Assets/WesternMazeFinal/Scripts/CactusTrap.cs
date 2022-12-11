using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusTrap : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sound.Play();
            player.transform.position = spawnPoint.transform.position;
            Quaternion defaultRotation = spawnPoint.rotation;
            player.transform.rotation = defaultRotation;
            Physics.SyncTransforms();
        }
    }


}
