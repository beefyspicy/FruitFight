using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathChecker : MonoBehaviour {

    /*public GameObject player1;
    public GameObject player2;

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

    bool isDead = false;
    bool isDead2 = false;

    //var p1pos;
    //var p2pos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 p1pos = player1.transform.position;
        Quaternion p1rot = player1.transform.rotation;

        Vector3 p2pos = player2.transform.position;
        Quaternion p2rot = player2.transform.rotation;

        //deathSpawn = player1.transform.position;

        if (Player2DController.playerHealth < 1)
        {
            isDead = true;
        }
        if (Player22DController.playerHealth < 1)
        {
            isDead2 = true;
        }

        if (isDead)
        {
            //player1.SetActive(false);
            RoundManager.player2Score += 1;

            GameObject bodies = Instantiate(body, p1pos, p1rot);
            GameObject legs1 = Instantiate(frontLeg, p1pos, p1rot);
            GameObject legs2 = Instantiate(backLeg, p1pos, p1rot);
            GameObject arms1 = Instantiate(frontArm, p1pos, p1rot);
            GameObject arms2 = Instantiate(backArm, p1pos, p1rot);


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

            isDead = false;
            Player2DController.playerHealth = 2;
        }

        if (isDead2)
        {
            //player2.SetActive(false);
            RoundManager.player2Score += 1;

            GameObject bodies = Instantiate(body2, p2pos, p2rot);
            GameObject legs1 = Instantiate(frontLeg2, p2pos, p2rot);
            GameObject legs2 = Instantiate(backLeg2, p2pos, p2rot);
            GameObject arms1 = Instantiate(frontArm2, p2pos, p2rot);
            GameObject arms2 = Instantiate(backArm2, p2pos, p2rot);


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

            isDead2 = false;
            Player22DController.playerHealth = 2;
        }
    }*/
}
