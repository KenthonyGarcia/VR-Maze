using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MazeClear : MonoBehaviour
{
    public UnityEvent clear;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            clear.Invoke();
        }
    }
}
