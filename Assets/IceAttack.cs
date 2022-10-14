using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceAttack : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1) && anim.GetInteger("Ice") == 0)
        {
            anim.SetInteger("Ice", 1);
        }
        else if(Input.GetMouseButtonDown(1) && anim.GetInteger("Ice") == 1)
        {
            anim.SetInteger("Ice", 0);
        }
    }
}