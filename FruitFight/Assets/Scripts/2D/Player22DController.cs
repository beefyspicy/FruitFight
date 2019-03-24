using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player22DController : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public float downForce;
    public float lowForce;
    public static float playerHealth = 5;

    public static bool onGround;
    public static bool flipArms;

    public Text health;

    private Rigidbody2D rb;

    AudioSource audioSource;
    //public AudioClip ouch;
    public AudioClip jump1;
    public AudioClip jump2;

    void Start()
    {
        health.text = "Health: " + playerHealth;
        playerHealth = 5;

        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.AddForce(transform.up * downForce);
        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Alpha5))
        {
            rb.AddForce(transform.up * lowForce);
        }

        float moveHorizontal = Input.GetAxis("Player2Movement");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (moveHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            flipArms = false;
        }
        if (moveHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            flipArms = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5) && onGround == true)
        {
            onGround = false;
            //PlatformController.effector.rotationalOffset = 0f;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        //onGround = true;
        if (other.gameObject.CompareTag("Bullet"))
        {
            playerHealth -= 2;
            //health.text = "Health: " + playerHealth;
        }
        if (other.gameObject.CompareTag("AKBullet"))
        {
            playerHealth -= 2;
            //health.text = "Health: " + playerHealth;
            //audioSource.PlayOneShot(ouch, .5f);
        }
        if (other.gameObject.CompareTag("ShotgunPellet"))
        {
            playerHealth -= 4;
            //health.text = "Health: " + playerHealth;
        }
        if (playerHealth < 0)
        {
            //RoundManager.player1Score += 1;
            //playerHealth = 0;
            //health.text = "Health: " + playerHealth;
        }
        /*if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }*/
    }
}
