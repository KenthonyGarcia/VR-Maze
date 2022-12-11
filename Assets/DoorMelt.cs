using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMelt : MonoBehaviour
{
    public Transform door;

    public float meltSpeed = 0.3f;

    private bool melt = false;

    // Update is called once per frame
    void Update()
    {

        Vector3 meltPosition = new Vector3(door.position.x, -4.6f, door.position.z);

        if (melt) {
            door.position = Vector3.Lerp(door.position, meltPosition, Time.deltaTime * meltSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Torch"))
        {
            melt = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Torch"))
        {
            melt = false;
        }
    }
}