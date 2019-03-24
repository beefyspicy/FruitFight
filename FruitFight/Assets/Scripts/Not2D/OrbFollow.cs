using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbFollow : MonoBehaviour {

    public GameObject player;

    public float speed;

    //private Transform target;

	void Update ()
    {
        //target.transform.position = player.transform.position;

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }
}
