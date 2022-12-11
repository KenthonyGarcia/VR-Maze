using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1Collision : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.position = spawnPoint.transform.position;
            Quaternion defaultRotation = spawnPoint.rotation;
            player.transform.rotation = defaultRotation;
            Physics.SyncTransforms();      
        }
    }
}
