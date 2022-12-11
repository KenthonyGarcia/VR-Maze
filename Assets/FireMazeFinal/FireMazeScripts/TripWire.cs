using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TripWire : MonoBehaviour
{
    public UnityEvent onTrip;
    public GameObject tripwire;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            onTrip.Invoke();
            if(tripwire.CompareTag("TripWire"))
            {
                tripwire.SetActive(false);
            }
            Physics.SyncTransforms();
        }
    }
}