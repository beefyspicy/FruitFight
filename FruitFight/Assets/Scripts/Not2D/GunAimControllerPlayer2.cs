using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimControllerPlayer2 : MonoBehaviour {

    public GameObject player;

    private bool diagAim;

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 180, -45);
            }
        }

        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
        }

        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 180, 45);
            }
        }

        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            if (Player22DController.flipArms == true)
            {
                transform.rotation = Quaternion.Euler(0, 180, -90);
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            if (Player22DController.flipArms == true)
            {
                transform.rotation = Quaternion.Euler(0, 180, 90);
            }
        }
        else
        {
            transform.rotation = player.transform.rotation;
        }
    }
}
