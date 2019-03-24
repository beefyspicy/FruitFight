using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public GameObject body;
    public GameObject frontLeg;
    public GameObject backLeg;
    public GameObject frontArm;
    public GameObject backArm;

    public GameObject body2;
    public GameObject frontLeg2;
    public GameObject backLeg2;
    public GameObject frontArm2;
    public GameObject backArm2;

    public float deathForce;

    //AudioSource audioSource;
    //public AudioClip death;

    /*private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }*/

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (other.gameObject.CompareTag("Player") && Player1Controller.playerHealth <= 0)
        {
            other.gameObject.SetActive(false);
            //audioSource.PlayOneShot(death, .3f);

            GameObject bodies = Instantiate(body, other.transform.position, other.transform.rotation);
            GameObject legs1 = Instantiate(frontLeg, other.transform.position, other.transform.rotation);
            GameObject legs2 = Instantiate(backLeg, other.transform.position, other.transform.rotation);
            GameObject arms1 = Instantiate(frontArm, other.transform.position, other.transform.rotation);
            GameObject arms2 = Instantiate(backArm, other.transform.position, other.transform.rotation);


            Rigidbody rb = bodies.GetComponent<Rigidbody>();
            Rigidbody rb2 = legs1.GetComponent<Rigidbody>();
            Rigidbody rb3 = legs2.GetComponent<Rigidbody>();
            Rigidbody rb4 = arms1.GetComponent<Rigidbody>();
            Rigidbody rb5 = arms2.GetComponent<Rigidbody>();

            rb.AddForce(transform.right * deathForce, ForceMode.VelocityChange);
            rb2.AddForce(transform.up * deathForce, ForceMode.VelocityChange);
            rb3.AddForce(transform.right * deathForce, ForceMode.VelocityChange);
            rb4.AddForce(transform.up * deathForce, ForceMode.VelocityChange);
            rb5.AddForce(transform.right * deathForce, ForceMode.VelocityChange);


            Destroy(bodies, 2f);
            Destroy(legs1, 2f);
            Destroy(legs2, 2f);
            Destroy(arms1, 2f);
            Destroy(arms2, 2f);
        }


        if (other.gameObject.CompareTag("Player") && Player2Controller.playerHealth <= 0)
        {
            other.gameObject.SetActive(false);
            //audioSource.PlayOneShot(death, .3f);

            GameObject bodies = Instantiate(body2, other.transform.position, other.transform.rotation);
            GameObject legs1 = Instantiate(frontLeg2, other.transform.position, other.transform.rotation);
            GameObject legs2 = Instantiate(backLeg2, other.transform.position, other.transform.rotation);
            GameObject arms1 = Instantiate(frontArm2, other.transform.position, other.transform.rotation);
            GameObject arms2 = Instantiate(backArm2, other.transform.position, other.transform.rotation);


            Rigidbody rb = bodies.GetComponent<Rigidbody>();
            Rigidbody rb2 = legs1.GetComponent<Rigidbody>();
            Rigidbody rb3 = legs2.GetComponent<Rigidbody>();
            Rigidbody rb4 = arms1.GetComponent<Rigidbody>();
            Rigidbody rb5 = arms2.GetComponent<Rigidbody>();

            rb.AddForce(transform.right * deathForce, ForceMode.VelocityChange);
            rb2.AddForce(transform.up * deathForce, ForceMode.VelocityChange);
            rb3.AddForce(transform.right * deathForce, ForceMode.VelocityChange);
            rb4.AddForce(transform.up * deathForce, ForceMode.VelocityChange);
            rb5.AddForce(transform.right * deathForce, ForceMode.VelocityChange);


            Destroy(bodies, 2f);
            Destroy(legs1, 2f);
            Destroy(legs2, 2f);
            Destroy(arms1, 2f);
            Destroy(arms2, 2f);
        }
    }
}
