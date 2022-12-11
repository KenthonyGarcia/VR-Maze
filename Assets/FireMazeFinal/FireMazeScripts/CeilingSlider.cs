using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingSlider : MonoBehaviour
{
    public Transform Ceiling;
    [SerializeField] private Transform Slider;

    private Vector3 sliderLast;
    // Start is called before the first frame update
    void Start()
    {
        sliderLast = new Vector3(Slider.position.x, Slider.position.y, Slider.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 sliderCurr = new Vector3(Slider.position.x, Slider.position.y, Slider.position.z);
        // if(sliderCurr != sliderLast)
        // {
        //     var diff = sliderCurr.x - sliderLast.x;
        //     var multi = diff * 8000.0f;
        //     var newX = Ceiling.position.x + multi;
        //     Debug.Log(newX);
        //     Vector3 ceilingMove = new Vector3(newX, Ceiling.position.y, Ceiling.position.z);
        //     Ceiling.position = Vector3.Lerp(Ceiling.position, ceilingMove, Time.deltaTime * 5);
        //     sliderLast = sliderCurr;
        // }

        Vector3 sliderCurr = new Vector3(Slider.position.x, Slider.position.y, Slider.position.z);
        if(sliderCurr != sliderLast)
        {
            var diff = sliderCurr.x + 43.8f;
            var multi = diff * 60.0f;
            var newX = multi - 77.0f;
            // Debug.Log(newX);
            Vector3 ceilingMove = new Vector3(newX, Ceiling.position.y, Ceiling.position.z);
            Ceiling.position = Vector3.MoveTowards(Ceiling.position, ceilingMove, Time.deltaTime * 20);
        }
    }
}
