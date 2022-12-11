using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haunted_Respawn : MonoBehaviour
{
   public Transform player;
   public Transform spawn;

   public AudioSource sound;

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            sound.Play();
            Quaternion defaultRotation = spawn.rotation;
            player.transform.rotation = defaultRotation;
            player.transform.position = spawn.transform.position;
            Physics.SyncTransforms();
        }
    }
  
}
