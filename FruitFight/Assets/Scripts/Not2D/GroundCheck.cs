using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Player1Controller.onGround = true;
        Debug.Log("collided");
    }
}
