using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotator : MonoBehaviour
{
    public Transform door;

    private bool open = false;

    void Update()
    {
        if(open)
        {
            Quaternion currentRotation = door.rotation;
            Quaternion wantedRotation = Quaternion.Euler(0,90,0);
            door.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * 40);
        }
    }

    public void OpenDoor() {
        if(!open)
        {
            open = true;
        }
    }
}