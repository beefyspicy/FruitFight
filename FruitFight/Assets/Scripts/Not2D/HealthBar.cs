using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    Vector3 localScale;

	void Start ()
    {
        localScale = transform.localScale;
	}
	
	void Update ()
    {
        localScale.x = Player2DController.playerHealth;
        transform.localScale = localScale;
	}
}
