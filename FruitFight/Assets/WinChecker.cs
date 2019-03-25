using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinChecker : MonoBehaviour {

    public GameObject gameController;

    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text winText;


	// Update is called once per frame
	void Update ()
    {
        if (RoundManager.player1Score >= 3)
        {
            gameController.SetActive(false);
            StartCoroutine(WinCondition());
        }
        if (RoundManager.player2Score >= 3)
        {
            gameController.SetActive(false);
            StartCoroutine(WinConditionP2());
        }
    }

    IEnumerator WinCondition()
    {
        player1ScoreText.text = "Player 1 Score: 3";

        yield return new WaitForSeconds(0.3f);

        winText.text = "Player 1 Wins!";

        yield return new WaitForSeconds(1.5f);

        winText.text = "Exiting Area...";

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("InteractiveMenu");
    }

    IEnumerator WinConditionP2()
    {
        player1ScoreText.text = "Player 2 Score: 3";

        yield return new WaitForSeconds(0.3f);

        winText.text = "Player 2 Wins!";

        yield return new WaitForSeconds(1.5f);

        winText.text = "Exiting Area...";

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("InteractiveMenu");
    }
}
