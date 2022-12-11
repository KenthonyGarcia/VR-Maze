using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject boss;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private AudioSource gunSound;

    private bool insideTheArea = false;
    private float period = 0.0f;
    void Update()
    {
        if(insideTheArea)
        {
            Vector3 offset = player.transform.position;
            offset += new Vector3(0,0,10f);
            boss.transform.LookAt(offset);
            anim.SetInteger("Change",1);
            if (period > 1f)
            {
                Shoot_a_Bullet();
                period = 0;
            }
            period += UnityEngine.Time.deltaTime;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            insideTheArea = true;
            Debug.Log("Inside the area");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            insideTheArea = false;
            Debug.Log("Outside the area");
            anim.SetInteger("Change",0);
            boss.transform.rotation = this.transform.rotation;
        }
    }


    private void Shoot_a_Bullet()
    {
        GameObject aBullet = Instantiate(bullet,bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        aBullet.transform.localScale -= new Vector3(0.6f, 0.6f, 0.6f);
        aBullet.transform.LookAt(player);
        aBullet.transform.rotation = bulletSpawn.transform.rotation;
        Vector3 vector = new Vector3(aBullet.transform.position.x - player.transform.position.x, 0f, aBullet.transform.position.z - player.transform.position.z);
        vector.Normalize();
        aBullet.GetComponent<Rigidbody>().velocity = -vector * bulletSpeed;
        gunSound.Play();
        Destroy(aBullet, 7.0f);
    }
}
