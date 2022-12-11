using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreTorch : MonoBehaviour
{
    public GameObject torch;
    public GameObject torchImage;
    [SerializeField] private Transform player;
    [SerializeField] private Transform torchPos;
    private bool torchGrabbed;
    private bool stored;

    void Start()
    {
        torchGrabbed = false;
        stored = false;
        torchImage.SetActive(false);
    }

    public void Grab() {
        torchGrabbed = true;
    }
    public void Release() {
        torchGrabbed = false;
    }
    
    public void StoreTorchInBag() {
        if(stored)
        {
            Vector3 playerPos = player.transform.position;
            Vector3 playerDirection = player.transform.forward;
            Quaternion playerRotation = player.transform.rotation;
            float spawnDistance = 2;
            
            Vector3 spawnPos = playerPos + playerDirection*spawnDistance;

            torchPos.transform.rotation = playerRotation;
            torchPos.transform.position = spawnPos;
            Physics.SyncTransforms();
            torch.SetActive(true);
            stored = false;

            torchImage.SetActive(false);
        }
        else
        {
            if(torchGrabbed)
            {
                torch.SetActive(false);
                stored = true;
                torchImage.SetActive(true);
            }
        }
    }
}
