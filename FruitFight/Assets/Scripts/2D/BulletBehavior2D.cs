using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior2D : MonoBehaviour {

    //public GameObject player1;
    //public GameObject player2;

    public GameObject bloodfx;

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

    /*AudioSource audioSource;
    public AudioClip player1Defeated;
    public AudioClip player2Defeated;*/

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);

        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(bloodfx, other.transform.position, other.transform.rotation);
        }

        if (other.gameObject.CompareTag("Player") && Player2DController.playerHealth <= 1)
        {
            RoundManager.player2Score += 1;

            other.gameObject.SetActive(false);

            //audioSource.PlayOneShot(player1Defeated, .7f);

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


        if (other.gameObject.CompareTag("Player") && Player22DController.playerHealth <= 1)
        {
            RoundManager.player1Score += 1;

            other.gameObject.SetActive(false);

            //audioSource.PlayOneShot(player1Defeated, .7f);

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
            rb2.AddForce(transform.up * 4, ForceMode.VelocityChange);
            rb3.AddForce(transform.right * -8, ForceMode.VelocityChange);
            rb4.AddForce(transform.up * 8, ForceMode.VelocityChange);
            rb5.AddForce(transform.right * 4, ForceMode.VelocityChange);

            /*rb.AddExplosionForce(power, other.transform.position, radius, 0, ForceMode.VelocityChange);
            rb2.AddExplosionForce(power, other.transform.position, radius, 0, ForceMode.VelocityChange);
            rb3.AddExplosionForce(power, other.transform.position, radius, 0, ForceMode.VelocityChange);
            rb4.AddExplosionForce(power, other.transform.position, radius, 0, ForceMode.VelocityChange);
            rb5.AddExplosionForce(power, other.transform.position, radius, 0, ForceMode.VelocityChange);*/

            Destroy(bodies, 2f);
            Destroy(legs1, 2f);
            Destroy(legs2, 2f);
            Destroy(arms1, 2f);
            Destroy(arms2, 2f);
        }
    }
}
