using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElementalCollider : MonoBehaviour
{
    public UnityEvent ice;
     private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning("trigger");
        if(other.CompareTag("Elemental Hand")){
            Debug.LogWarning("elemental");
            ice.Invoke();
        }
    }
}
