using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    public static PlatformEffector2D effector;   //changing this from static to just public seems to fix bug --> needs to be tested

	// Use this for initialization
	void Start () {
        effector = GetComponent<PlatformEffector2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            effector.rotationalOffset = 0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 180f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            effector.rotationalOffset = 0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            effector.rotationalOffset = 180f;
        }
        /*if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 0f;
        }*/
    }
}
