using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CaveWarp : MonoBehaviour {

    public GameObject cavefx;
    public GameObject forest;
    public GameObject forestText;
    public GameObject tundra;
    public GameObject tundraText;

    public Text caveText;

    AudioSource audioSource;
    public AudioClip caveLevel;

    private bool canPlay = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        caveText.text = "";
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("AKBullet") || other.gameObject.CompareTag("ShotgunPellet"))
        {
            Instantiate(cavefx, transform.position, transform.rotation);

            tundra.SetActive(false);
            forest.SetActive(false);
            tundraText.SetActive(false);
            forestText.SetActive(false);

            StartCoroutine(CaveStart());
        }
    }

    IEnumerator CaveStart()
    {
        yield return new WaitForSeconds(0.3f);
        caveText.text = "Loading Volcano Area...";

        if (!canPlay)
        {
            audioSource.PlayOneShot(caveLevel, 1.8f);
            canPlay = true;
        }

        RoundManager.player1Score = 0;
        RoundManager.player2Score = 0;

        //Player2DController.playerHealth = 5;
        //Player22DController.playerHealth = 5;

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("CaveLevel1");
    }
}
