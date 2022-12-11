using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 using UnityEngine.UI;

public class TileStep : MonoBehaviour
{
    public UnityEvent onStep;
    public Material Material1;
    public GameObject tile;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            tile.GetComponent<MeshRenderer> ().material = Material1;
            onStep.Invoke();

            Physics.SyncTransforms();
        }
    }
}