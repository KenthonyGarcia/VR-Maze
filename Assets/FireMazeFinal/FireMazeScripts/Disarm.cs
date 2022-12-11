using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disarm : MonoBehaviour
{
    public GameObject tripwire;

    public void DisarmWire()
    {
        tripwire.SetActive(false);
    }
}
