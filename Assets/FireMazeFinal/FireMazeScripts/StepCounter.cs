using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StepCounter : MonoBehaviour
{
    public UnityEvent AllStep;
    // Start is called before the first frame update

    private bool tile1 = false;
    private bool tile2 = false;
    private bool tile3 = false;
    private bool once = true;

    // Update is called once per frame
    public void OpenDecoys()
    {
        if(tile1 && tile2 && tile3 && once)
        {
            AllStep.Invoke();
            once = false;
        }
    }

    public void stepTile1()
    {
        tile1 = true;
        OpenDecoys();
    }
    public void stepTile2()
    {
        tile2 = true;
        OpenDecoys();
    }
    public void stepTile3()
    {
        tile3 = true;
        OpenDecoys();
    }
}
