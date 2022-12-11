using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player hit trap floor");
            Quaternion defaultRotation = spawnPoint.rotation;
            player.transform.rotation = defaultRotation;
            player.transform.position = spawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}