using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarPlayer2 : MonoBehaviour {

    Vector3 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = Player22DController.playerHealth;
        transform.localScale = localScale;
    }
}
