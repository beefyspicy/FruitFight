using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Controller : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public float downForce;
    public float lowForce;
    public static float playerHealth = 5;

    public static bool onGround;

    public Text health;

    private Rigidbody rb;

    AudioSource audioSource;
    //public AudioClip ouch;
    public AudioClip jump1;
    public AudioClip jump2;

    void Start()
    {
        health.text = "Health: " + playerHealth;

        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.AddForce(transform.up * downForce);
        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown("space"))
        {
            rb.AddForce(transform.up * lowForce);
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (moveHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        if (moveHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && onGround == true)
        {
            onGround = false;
            //Debug.Log("on ground false");
            rb.velocity = Vector2.up * jumpForce;

            float r = Random.Range(0, 3);
            if (r == 0)
            {
                audioSource.PlayOneShot(jump1, .2f);
            }
            if (r == 1)
            {
                audioSource.PlayOneShot(jump1, .2f);
            }
            if (r == 2)
            {
                audioSource.PlayOneShot(jump2, .2f);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        //onGround = true;
        if (other.gameObject.CompareTag("Bullet"))
        {
            playerHealth -= 1;
            health.text = "Health: " + playerHealth;
        }
        if (other.gameObject.CompareTag("AKBullet"))
        {
            playerHealth -= 2;
            health.text = "Health: " + playerHealth;
            //audioSource.PlayOneShot(ouch, .5f);
        }
        if (other.gameObject.CompareTag("ShotgunPellet"))
        {
            playerHealth -= 5;
            health.text = "Health: " + playerHealth;
        }
        if (playerHealth < 0)
        {
            playerHealth = 0;
        }
        /*if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }*/
    }
}
