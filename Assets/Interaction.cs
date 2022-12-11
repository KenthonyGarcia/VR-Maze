using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    Animator Attack;
    // Start is called before the first frame update
    void Start()
    {
        Attack = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    public void Skeleton1_Attack(){
        Attack.SetInteger("Skeleton",1);
    }
     public void Skeleton1_Stop(){
        Attack.SetInteger("Skeleton",0);
    }
    public void Wizard_Attack(){
        Attack.SetInteger("Wizard",1);
    }
     public void Wizard_Stop(){
        Attack.SetInteger("Wizard",0);
    }
}
