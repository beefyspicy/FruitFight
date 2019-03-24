using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2D : MonoBehaviour {

    public GameObject exitPortal;
    public GameObject exitFallPortal;
    public GameObject exitPortal2;
    public GameObject exitFallPortal2;
    public GameObject exitPortal3;
    public GameObject exitFallPortal3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            gameObject.transform.position = exitPortal.transform.position;
        }
        if (other.gameObject.CompareTag("FallPortal"))
        {
            gameObject.transform.position = exitFallPortal.transform.position;
        }

        if (other.gameObject.CompareTag("Portal2"))
        {
            gameObject.transform.position = exitPortal2.transform.position;
        }
        if (other.gameObject.CompareTag("FallPortal2"))
        {
            gameObject.transform.position = exitFallPortal2.transform.position;

        }

        if (other.gameObject.CompareTag("Portal3"))
        {
            gameObject.transform.position = exitPortal3.transform.position;
        }
        if (other.gameObject.CompareTag("FallPortal3"))
        {
            gameObject.transform.position = exitFallPortal3.transform.position;
        }
    }
}
