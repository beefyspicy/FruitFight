using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2DController : MonoBehaviour {

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
        //health.text = "Health: " + playerHealth;
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
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * lowForce);
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (moveHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            flipArms = true;
        }
        if (moveHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            flipArms = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            //PlatformController.effector.rotationalOffset = 0f;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        //onGround = true;
        if (other.gameObject.CompareTag("Bullet"))
        {
            playerHealth -= 2f;
            //health.text = "Health: " + playerHealth;
        }
        if (other.gameObject.CompareTag("AKBullet"))
        {
            playerHealth -= 2f;
            //health.text = "Health: " + playerHealth;
            //audioSource.PlayOneShot(ouch, .5f);
        }
        if (other.gameObject.CompareTag("ShotgunPellet"))
        {
            playerHealth -= 4f;
            //health.text = "Health: " + playerHealth;
        }
        if (playerHealth < 0)
        {
            //RoundManager.player2Score += 1;
            //playerHealth = 0;
            //health.text = "Health: " + playerHealth;
        }
        /*if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }*/
    }
}
