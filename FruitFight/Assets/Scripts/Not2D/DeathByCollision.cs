using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByCollision : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject == player1)
        {
            Player2DController.playerHealth = -5;
            RoundManager.player2Score += 1;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject == player2)
        {
            Player22DController.playerHealth = -5;
            RoundManager.player1Score += 1;
            other.gameObject.SetActive(false);
        }
    }
}
