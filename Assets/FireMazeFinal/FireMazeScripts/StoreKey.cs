using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StoreKey : MonoBehaviour
{
    public UnityEvent Open;

    public GameObject key;
    public GameObject keyImage;
    [SerializeField] private Transform player;
    [SerializeField] private Transform keyPos;
    private bool keyGrabbed;
    private bool stored;

    void Start()
    {
        keyGrabbed = false;
        stored = false;
        keyImage.SetActive(false);
    }

    public void Grab() {
        keyGrabbed = true;
    }
    public void Release() {
        keyGrabbed = false;
    }
    
    public void StoreKeyInBag() {
        if(stored)
        {
            Vector3 playerPos = player.transform.position;
            Vector3 playerDirection = player.transform.forward;
            Quaternion playerRotation = player.transform.rotation;
            float spawnDistance = 2;
            
            Vector3 spawnPos = playerPos + playerDirection*spawnDistance;

            keyPos.transform.rotation = playerRotation;
            keyPos.transform.position = spawnPos;
            Physics.SyncTransforms();
            key.SetActive(true);
            stored = false;

            keyImage.SetActive(false);
        }
        else
        {
            if(keyGrabbed)
            {
                key.SetActive(false);
                stored = true;
                keyImage.SetActive(true);
            }
        }
    }

    public void OpenGate() {
        if(keyGrabbed)
        {
            Open.Invoke();
        }
    }
}
