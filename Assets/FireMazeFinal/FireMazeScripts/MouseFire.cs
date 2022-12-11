using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFire : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetMouseButtonDown(1) && anim.GetInteger("Fire") == 0)
    //     {
    //         anim.SetInteger("Fire", 1);
    //     }
    //     else if(Input.GetMouseButtonDown(1) && anim.GetInteger("Fire") == 1)
    //     {
    //         anim.SetInteger("Fire", 0);
    //     }
    // }

    public void DragonFire(){
        anim.SetInteger("Fire", 1);
    }
    public void StopFire() {
        anim.SetInteger("Fire", 0);
    }
}
