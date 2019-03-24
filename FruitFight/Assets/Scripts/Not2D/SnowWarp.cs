using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SnowWarp : MonoBehaviour {

    public GameObject tundrafx;
    public GameObject cave;
    public GameObject forest;
    public GameObject caveText;
    public GameObject forestText;

    public Text snowText;

    AudioSource audioSource;
    public AudioClip snowLevel;

    private bool canPlay = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        snowText.text = "";
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("AKBullet") || other.gameObject.CompareTag("ShotgunPellet"))
        {
            Instantiate(tundrafx, transform.position, transform.rotation);

            cave.SetActive(false);
            forest.SetActive(false);
            forestText.SetActive(false);
            caveText.SetActive(false);

            StartCoroutine(SnowStart());
        }
    }

    IEnumerator SnowStart()
    {
        yield return new WaitForSeconds(0.3f);
        snowText.text = "Loading Tundra Area...";

        if (!canPlay)
        {
            audioSource.PlayOneShot(snowLevel, 1.8f);
            canPlay = true;
        }

        RoundManager.player1Score = 0;
        RoundManager.player2Score = 0;

        //Player2DController.playerHealth = 5;
        //Player22DController.playerHealth = 5;

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SnowLevel1");
    }
}
