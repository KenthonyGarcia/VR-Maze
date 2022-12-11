using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class ExplosiveTrap : MonoBehaviour
{
    [SerializeField] public AudioSource dynamiteStart;
    [SerializeField] public AudioSource dynamiteExplosion;
    [SerializeField] private GameObject trap;
    [SerializeField] public GameObject walls;
    [SerializeField] public GameObject bricks;


    public UnityEvent Activated;


    
    void Awake(){
        bricks.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Destroy(walls,6f);
        bricks.SetActive(true);
        dynamiteStart.Play();
        dynamiteExplosion.PlayDelayed(5.5f);
        Activated.Invoke();
        Destroy(trap,6f);
    }
}
