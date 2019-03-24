using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecker : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Player1Controller.onGround = true;
    }
}
