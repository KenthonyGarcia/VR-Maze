using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnIce : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.transform.position = spawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}