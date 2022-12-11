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
    public void IceShards(){
        anim.SetInteger("Ice", 1);
    }
    public void StopShards() {
        anim.SetInteger("Ice", 0);
    }
}