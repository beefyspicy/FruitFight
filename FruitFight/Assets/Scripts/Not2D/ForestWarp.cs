using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ForestWarp : MonoBehaviour {

    public GameObject forestfx;
    public GameObject cave;
    public GameObject tundra;
    public GameObject tundraText;
    public GameObject caveText;

    public Text forestText;

    AudioSource audioSource;
    public AudioClip forestLevel;

    private bool canPlay = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        forestText.text = "";
    }

    /*public void Forest()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }*/

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("AKBullet") || other.gameObject.CompareTag("ShotgunPellet"))
        {
            Instantiate(forestfx, transform.position, transform.rotation);

            cave.SetActive(false);
            tundra.SetActive(false);
            caveText.SetActive(false);
            tundraText.SetActive(false);

            StartCoroutine(ForestStart());
        }
    }

    IEnumerator ForestStart()
    {
        yield return new WaitForSeconds(0.3f);
        forestText.text = "Loading Forest Area...";

        if(!canPlay)
        {
            audioSource.PlayOneShot(forestLevel, 1.8f);
            canPlay = true;
        }

        RoundManager.player1Score = 0;
        RoundManager.player2Score = 0;

        //Player2DController.playerHealth = 5;
        //Player22DController.playerHealth = 5;

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("ForestLevel1");
    }
}
