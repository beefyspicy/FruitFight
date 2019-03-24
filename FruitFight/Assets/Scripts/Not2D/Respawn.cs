using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public float respawnTime;

    public GameObject player1;
    public GameObject player1Spawn;
    public GameObject player2;
    public GameObject player2Spawn;

    void LateUpdate ()
    {
        if (!player1.activeSelf)
        {
            StartCoroutine(RespawnTimer());
            //StopCoroutine(RespawnTimer());
        }
        if (!player2.activeSelf)
        {
            StartCoroutine(RespawnTimerPlayer2());
            //StopCoroutine(RespawnTimerPlayer2());
        }
    }

    IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(respawnTime);
        player1.transform.position = player1Spawn.transform.position;
        Player2DController.playerHealth = 5;
        player1.SetActive(true);

        //Instantiate(player1, player1Spawn.transform.position, player1Spawn.transform.rotation);
    }

    IEnumerator RespawnTimerPlayer2()
    {
        yield return new WaitForSeconds(respawnTime);
        player2.transform.position = player2Spawn.transform.position;
        Player22DController.playerHealth = 5;
        player2.SetActive(true);

        //Instantiate(player2, player2Spawn.transform.position, player2Spawn.transform.rotation);
    }
}
