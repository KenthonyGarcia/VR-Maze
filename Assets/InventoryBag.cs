using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBag : MonoBehaviour
{
    public GameObject button;
    private bool bagActive;
    private bool torchGrabbed;

    void Start()
    {
        button.SetActive(false);
    }

    public void ShowBag() {
        if(bagActive)
        {
            bagActive = false;
        }
        else
        {
            bagActive = true;
        }
        button.SetActive(bagActive);
    }

    public void Grab() {
        torchGrabbed = true;
    }
    public void Release() {
        torchGrabbed = false;
    }
    
}
