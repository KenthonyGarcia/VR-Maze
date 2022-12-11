using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBag : MonoBehaviour
{
    public GameObject button;
    private bool bagActive;

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
}
