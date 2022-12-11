using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AnimationTrigger : MonoBehaviour
{
    public UnityEvent Spotted;
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Spotted.Invoke();
            Debug.Log("Working");
        }
    }
    public UnityEvent Unspotted;
     private void OnTriggerExit(Collider other){
        if (other.CompareTag("Player")){
            Unspotted.Invoke();
        }
    }
  
}
