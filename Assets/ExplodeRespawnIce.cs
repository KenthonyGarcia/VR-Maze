using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeRespawnIce : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            Quaternion defaultRotation = spawnPoint.rotation;
            player.transform.rotation = defaultRotation;
            player.transform.position = spawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
