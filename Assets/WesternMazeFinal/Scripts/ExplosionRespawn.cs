using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Player"))
        {
            player.transform.position = spawnPoint.transform.position;
            Quaternion defaultRotation = spawnPoint.rotation;
            player.transform.rotation = defaultRotation;
            Physics.SyncTransforms();
        }
    }

}
