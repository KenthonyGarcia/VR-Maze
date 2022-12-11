using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    private bool GateOpen;
    public Transform gate;
    public GameObject keyholeObj;
    public GameObject gateObj;

    void Start()
    {
        GateOpen = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(GateOpen) {
            Vector3 openPosition = new Vector3(gate.position.x, 100.0f, gate.position.z);
            gate.position = Vector3.Lerp(gate.position, openPosition, Time.deltaTime * 10f);
            keyholeObj.SetActive(false);
            if(gate.position.y >= 90.0f)
            {
                gateObj.SetActive(false);
            }
        }
    }

    public void OpenLast()
    {
        GateOpen = true;
    }
}
