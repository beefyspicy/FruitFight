using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour {

    public GameObject ak;
    public GameObject pistol;
    public GameObject shotgun;

    AudioSource audioSource;
    public AudioClip nowWeTalkin;
    public AudioClip alright;
    public AudioClip letsDoIt;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);

        if (other.gameObject.CompareTag("AK"))
        {
            audioSource.PlayOneShot(nowWeTalkin, .4f);
            other.gameObject.SetActive(false);
            ak.SetActive(true);
            pistol.SetActive(false);
            shotgun.SetActive(false);
        }
        if (other.gameObject.CompareTag("Pistol"))
        {
            audioSource.PlayOneShot(alright, .4f);
            other.gameObject.SetActive(false);
            pistol.SetActive(true);
            ak.SetActive(false);
            shotgun.SetActive(false);
        }
        if (other.gameObject.CompareTag("Shotgun"))
        {
            audioSource.PlayOneShot(letsDoIt, .4f);
            other.gameObject.SetActive(false);
            shotgun.SetActive(true);
            pistol.SetActive(false);
            ak.SetActive(false);
        }
    }
}
