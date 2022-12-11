using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class ButtonPhysics : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;


    [SerializeField] public GameObject walls;
    [SerializeField] public GameObject bricks;



    private bool isPressed;
    private Vector3 startPos;
    private ConfigurableJoint _joint;


    public UnityEvent onPressed, onReleased;



    void Awake(){
                bricks.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

        startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPressed && GetValue() + threshold >=1)
            Pressed();
        if(isPressed && GetValue() - threshold <=0)
            Released();
    }

    private float GetValue()
    {
        var value = Vector3.Distance(startPos,transform.localPosition) / _joint.linearLimit.limit;
        if(Math.Abs(value)<deadZone)
            value = 0;

        return Mathf.Clamp(value,-1f,1f);
    }


    private void Pressed()
    {
        isPressed = true;
        onPressed.Invoke();


        Destroy(walls);
        bricks.SetActive(true);

        Debug.Log("Pressed");
    }

    private void Released()
    {
        isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
    }


}
