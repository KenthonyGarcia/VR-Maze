using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SliderHiderExplode : MonoBehaviour
{
    public Transform SliderHider;
    public GameObject SliderHiderObj;
    public UnityEvent Explode;

    private bool open = false;

    private float speed = .2f;

    void Update()
    {
        Vector3 openPosition = new Vector3(SliderHider.position.x, 100.0f, SliderHider.position.z);

        if (open) {
            SliderHider.position = Vector3.Lerp(SliderHider.position, openPosition, Time.deltaTime * speed);
        }
        if(SliderHider.position.y >= 89.0f)
        {
            Explode.Invoke();
        }
        if(SliderHider.position.y >= 90.0f)
        {
            SliderHiderObj.SetActive(false);
        }
    }

    public void UnhideSlider() {
        open = true;
    }
}
