using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public Text round;
    public Text fightText;
    public Text winText;
    public Text player1ScoreText;
    public Text player2ScoreText;

    public static float player1Score;
    public static float player2Score;

    //private bool playerWin = false;
    bool canPlaySound = false;
    bool canPlaySound2 = false;

    AudioSource audioSource;
    public AudioClip round1;
    public AudioClip fight;
    public AudioClip player1Defeated;
    public AudioClip player2Defeated;


    void Start ()
    {
        round.text = "";
        fightText.text = "";
        winText.text = "";
        player1ScoreText.text = "Player 1 Score: " + player1Score;
        player2ScoreText.text = "Player 2 Score: " + player2Score;

        player1.SetActive(false);
        player2.SetActive(false);  //could try disabling just the movement script instead

        audioSource = GetComponent<AudioSource>();
        StartCoroutine(RoundStart());
    }

    void Update ()
    {
        //StartCoroutine(WinChecker());
        RoundChecker();

        if (Input.GetKey(KeyCode.Escape))
        {
            //Debug.Log("Quit");
            //Application.Quit();
            SceneManager.LoadScene("InteractiveMenu");
        }

        if (Player2DController.playerHealth < 1)
        {
            if(!canPlaySound)
            {
                audioSource.PlayOneShot(player1Defeated, .7f);
                canPlaySound = true;
            }
        }

        if (Player22DController.playerHealth < 1)
        {
            if (!canPlaySound2)
            {
                audioSource.PlayOneShot(player2Defeated, .7f);
                canPlaySound2 = true;
            }
        }
    }

    /*IEnumerator WinChecker()
    {
        if(player1Score == 3)
        {
            playerWin = true;

            winText.text = "Player 1 Wins!!!";
            yield return new WaitForSeconds(2f);
            winText.text = "Exiting Forest Area...";
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("InteractiveMenu");
        }
        if (player2Score == 3)
        {
            playerWin = true;

            winText.text = "Player 2 Wins!!!";
            yield return new WaitForSeconds(2f);
            winText.text = "Exiting Forest Area...";
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("InteractiveMenu");
        }
    }*/

    IEnumerator RoundStart()
    {
        Player2DController.playerHealth = 5;
        Player22DController.playerHealth = 5;

        yield return new WaitForSeconds(0.5f);
        round.text = "Round 1";
        audioSource.PlayOneShot(round1, .7f);
        yield return new WaitForSeconds(2f);
        round.text = "";
        fightText.text = "Fight!";
        audioSource.PlayOneShot(fight, .7f);
        yield return new WaitForSeconds(0.1f);

        player1.SetActive(true);
        player2.SetActive(true);

        yield return new WaitForSeconds(0.3f);
        fightText.text = "";
    }

    void RoundChecker()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "InteractiveMenu" && Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //forest levels

        else if (sceneName == "ForestLevel1" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(EndRound());
        }
        else if (sceneName == "ForestLevel2" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(EndRound2());
        }
        else if (sceneName == "ForestLevel3" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(EndRound3());
        }
        else if (sceneName == "ForestLevel4" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(EndRound4());
        }
        else if (sceneName == "ForestLevel5" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(EndRound5());
        }

        //snow levels

        else if (sceneName == "SnowLevel1" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(SnowEndRound());
        }
        else if (sceneName == "SnowLevel2" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(SnowEndRound2());
        }
        else if (sceneName == "SnowLevel3" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(SnowEndRound3());
        }
        else if (sceneName == "SnowLevel4" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(SnowEndRound4());
        }
        else if (sceneName == "SnowLevel5" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(SnowEndRound5());
        }

        //cave levels

        else if (sceneName == "CaveLevel1" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(CaveEndRound());
        }
        else if (sceneName == "CaveLevel2" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(CaveEndRound2());
        }
        else if (sceneName == "CaveLevel3" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(CaveEndRound3());
        }
        else if (sceneName == "CaveLevel4" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(CaveEndRound4());
        }
        else if (sceneName == "CaveLevel5" && (Player2DController.playerHealth <= 0 || Player22DController.playerHealth <= 0))
        {
            StartCoroutine(CaveEndRound5());
        }
    }




    //forest levels

    IEnumerator EndRound()
    {
        if(Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, .7f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel2");
        }
        if(Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, .7f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel2");
        }
    }

    IEnumerator EndRound2()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel3");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel3");
        }
    }

    IEnumerator EndRound3()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel4");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel4");
        }
    }

    IEnumerator EndRound4()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel5");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("ForestLevel5");
        }
    }
    IEnumerator EndRound5()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Exiting Forest Area...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("InteractiveMenu");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Exiting Forest Area...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("InteractiveMenu");
        }
    }

    //snow levels

    IEnumerator SnowEndRound()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel2");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel2");
        }
    }

    IEnumerator SnowEndRound2()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel3");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel3");
        }
    }


    IEnumerator SnowEndRound3()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel4");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel4");
        }
    }


    IEnumerator SnowEndRound4()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel5");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("SnowLevel5");
        }
    }

    IEnumerator SnowEndRound5()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Exiting Tundra Area...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("InteractiveMenu");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Exiting Tundra Area...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("InteractiveMenu");
        }
    }


    //cave levels

    IEnumerator CaveEndRound()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel2");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel2");
        }
    }

    IEnumerator CaveEndRound2()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel3");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel3");
        }
    }

    IEnumerator CaveEndRound3()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel4");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel4");
        }
    }

    IEnumerator CaveEndRound4()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel5");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Loading Next Round...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("CaveLevel5");
        }
    }

    IEnumerator CaveEndRound5()
    {
        if (Player2DController.playerHealth < 0)
        {
            //player2Score += 1;
            player2ScoreText.text = "Player 2 Score: " + player2Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 1 Defeated!";
            //audioSource.PlayOneShot(player1Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Exiting Volcano Area...";
            Player2DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("InteractiveMenu");
        }
        if (Player22DController.playerHealth < 0)
        {
            //player1Score += 1;
            player1ScoreText.text = "Player 1 Score: " + player1Score;

            yield return new WaitForSeconds(0.3f);

            winText.text = "Player 2 Defeated!";
            //audioSource.PlayOneShot(player2Defeated, 1.5f);

            yield return new WaitForSeconds(1.5f);

            winText.text = "Exiting Volcano Area...";
            Player22DController.playerHealth = 5;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene("InteractiveMenu");
        }
    }
}
