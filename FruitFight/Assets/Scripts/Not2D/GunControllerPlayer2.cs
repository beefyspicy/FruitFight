using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControllerPlayer2 : MonoBehaviour {

    public float bulletForce;
    public float shellForce;
    public float shellForce2;
    public float fireRate;

    private float lastFired;

    public GameObject bullet;
    public GameObject bulletSpawn;
    public GameObject shell;
    public GameObject shellSpawn;
    public GameObject muzzleFlash;

    public GameObject pelletSpawn;
    public GameObject pelletSpawn2;


    public GameObject ak;
    public GameObject shotgun;
    public GameObject pistol;

    AudioSource audioSource;
    public AudioClip rifleFire;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButton("Player2Fire"))
        {
            AK();
            Shotgun();
            Pistol();
        }
    }

    void AK()
    {
        if (ak.activeSelf)
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                lastFired = Time.time;

                audioSource.PlayOneShot(rifleFire, .38f);

                GameObject bullets = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject mFlash = Instantiate(muzzleFlash, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject shells = Instantiate(shell, shellSpawn.transform.position, bulletSpawn.transform.rotation);

                Rigidbody rb = bullets.GetComponent<Rigidbody>();
                Rigidbody rbShells = shells.GetComponent<Rigidbody>();

                rb.AddForce(transform.right * bulletForce, ForceMode.VelocityChange);
                rbShells.AddForce(transform.up * shellForce, ForceMode.VelocityChange);
                rbShells.AddForce(transform.right * shellForce2, ForceMode.VelocityChange);

                Destroy(bullets, 2f);
                Destroy(mFlash, 0.05f);
                Destroy(shells, 2f);
            }
        }
    }

    void Shotgun()
    {
        if (shotgun.activeSelf)
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                lastFired = Time.time;

                audioSource.PlayOneShot(rifleFire, .1f);

                GameObject bullets = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject bullets2 = Instantiate(bullet, pelletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject bullets3 = Instantiate(bullet, pelletSpawn2.transform.position, bulletSpawn.transform.rotation);


                GameObject mFlash = Instantiate(muzzleFlash, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject shells = Instantiate(shell, shellSpawn.transform.position, bulletSpawn.transform.rotation);

                Rigidbody rb = bullets.GetComponent<Rigidbody>();
                Rigidbody rb2 = bullets2.GetComponent<Rigidbody>();
                Rigidbody rb3 = bullets3.GetComponent<Rigidbody>();


                Rigidbody rbShells = shells.GetComponent<Rigidbody>();

                rb.AddForce(transform.right * bulletForce, ForceMode.VelocityChange);
                rb2.AddForce(transform.right * bulletForce, ForceMode.VelocityChange);
                rb3.AddForce(transform.right * bulletForce, ForceMode.VelocityChange);


                rbShells.AddForce(transform.up * shellForce, ForceMode.VelocityChange);
                rbShells.AddForce(transform.right * shellForce2, ForceMode.VelocityChange);

                Destroy(bullets, 2f);
                Destroy(bullets2, 2f);
                Destroy(bullets3, 2f);

                Destroy(mFlash, 0.05f);
                Destroy(shells, 2f);
            }
        }
    }

    void Pistol()
    {
        if (pistol.activeSelf)
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                lastFired = Time.time;

                audioSource.PlayOneShot(rifleFire, .4f);

                GameObject bullets = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject mFlash = Instantiate(muzzleFlash, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                GameObject shells = Instantiate(shell, shellSpawn.transform.position, bulletSpawn.transform.rotation);

                Rigidbody rb = bullets.GetComponent<Rigidbody>();
                Rigidbody rbShells = shells.GetComponent<Rigidbody>();

                rb.AddForce(transform.right * bulletForce, ForceMode.VelocityChange);
                rbShells.AddForce(transform.up * shellForce, ForceMode.VelocityChange);
                rbShells.AddForce(transform.right * shellForce2, ForceMode.VelocityChange);

                Destroy(bullets, 2f);
                Destroy(mFlash, 0.05f);
                Destroy(shells, 2f);
            }
        }
    }
}
