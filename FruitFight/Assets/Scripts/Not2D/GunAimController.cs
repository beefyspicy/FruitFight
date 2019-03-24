using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimController : MonoBehaviour {

    public GameObject player;

    bool diagAim = false;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            diagAim = true;
            if(diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
        }

        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 180, 45);
            }
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            diagAim = true;
            if (diagAim)
            {
                transform.rotation = Quaternion.Euler(0, 180, -45);
            }
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            if (Player2DController.flipArms == true)
            {
                transform.rotation = Quaternion.Euler(0, 180, 90);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            if (Player2DController.flipArms == true)
            {
                transform.rotation = Quaternion.Euler(0, 180, -90);
            }
        }
        else
        {
            transform.rotation = player.transform.rotation;
        }
    }
}
