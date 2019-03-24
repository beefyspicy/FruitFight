using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup2D : MonoBehaviour {

    public GameObject ak;
    public GameObject pistol;
    public GameObject shotgun;
    public GameObject staff;
    public GameObject laser;

    AudioSource audioSource;
    public AudioClip nowWeTalkin;
    public AudioClip alright;
    public AudioClip letsDoIt;
    public AudioClip woah;
    public AudioClip what;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(other.gameObject);

        if (other.gameObject.CompareTag("AK"))
        {
            if(!ak.activeSelf)
            {
                audioSource.PlayOneShot(nowWeTalkin, .2f);
                other.gameObject.SetActive(false);
                ak.SetActive(true);
                pistol.SetActive(false);
                shotgun.SetActive(false);
                staff.SetActive(false);
                laser.SetActive(false);
            }
        }
        if (other.gameObject.CompareTag("Pistol"))
        {
            if(!pistol.activeSelf)
            {
                audioSource.PlayOneShot(alright, .2f);
                other.gameObject.SetActive(false);
                pistol.SetActive(true);
                ak.SetActive(false);
                shotgun.SetActive(false);
                staff.SetActive(false);
                laser.SetActive(false);
            }
        }
        if (other.gameObject.CompareTag("Shotgun"))
        {
            if (!shotgun.activeSelf)
            {
                audioSource.PlayOneShot(letsDoIt, .2f);
                other.gameObject.SetActive(false);
                shotgun.SetActive(true);
                pistol.SetActive(false);
                ak.SetActive(false);
                staff.SetActive(false);
                laser.SetActive(false);
            }
        }
        if (other.gameObject.CompareTag("Staff"))
        {
            if (!staff.activeSelf)
            {
                audioSource.PlayOneShot(woah, .2f);
                staff.SetActive(true);
                other.gameObject.SetActive(false);
                shotgun.SetActive(false);
                pistol.SetActive(false);
                ak.SetActive(false);
                laser.SetActive(false);
            }
        }
        if (other.gameObject.CompareTag("Laser"))
        {
            if (!laser.activeSelf)
            {
                audioSource.PlayOneShot(what, .2f);
                laser.SetActive(true);
                staff.SetActive(false);
                other.gameObject.SetActive(false);
                shotgun.SetActive(false);
                pistol.SetActive(false);
                ak.SetActive(false);
            }
        }
    }
}
