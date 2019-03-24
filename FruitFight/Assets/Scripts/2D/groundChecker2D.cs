using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker2D : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player2DController.onGround = true;
        //Debug.Log("2D on ground true");
    }
}
