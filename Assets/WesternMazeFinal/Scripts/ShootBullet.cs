using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet1;
    [SerializeField] private GameObject bullet2;
    [SerializeField] private GameObject bullet3;
    [SerializeField] private GameObject bullet4;
    [SerializeField] private GameObject bullet5;
    [SerializeField] private float bulletSpeed;
    [SerializeField] public AudioSource gun_sound1;
    [SerializeField] public AudioSource gun_sound2;
    [SerializeField] public AudioSource gun_sound3;
    [SerializeField] public AudioSource gun_sound4;
    [SerializeField] public AudioSource gun_sound5;

    private void OnTriggerEnter(Collider other)
    {   
        Destroy(this.gameObject);

        gun_sound1.Play();
        bullet1.GetComponent<Rigidbody>().velocity = bullet1.transform.up * bulletSpeed;
        Destroy(bullet1, 7.0f);

        gun_sound2.PlayDelayed(0.05f);
        bullet2.GetComponent<Rigidbody>().velocity = bullet2.transform.up * bulletSpeed;
        Destroy(bullet2, 7.0f);

        gun_sound3.PlayDelayed(0.1f);
        bullet3.GetComponent<Rigidbody>().velocity = bullet3.transform.up * bulletSpeed;
        Destroy(bullet3, 7.0f);

        gun_sound4.PlayDelayed(0.15f);
        bullet4.GetComponent<Rigidbody>().velocity = bullet4.transform.up * bulletSpeed;
        Destroy(bullet4, 7.0f);

        gun_sound5.PlayDelayed(0.2f);
        bullet5.GetComponent<Rigidbody>().velocity = bullet5.transform.up * bulletSpeed;
        Destroy(bullet5, 7.0f);
    }
}

