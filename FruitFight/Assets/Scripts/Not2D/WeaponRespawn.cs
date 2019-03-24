using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRespawn : MonoBehaviour {

    public float respawnTime;

    public GameObject ak;
    public GameObject akSpawn;
    public GameObject shotgun;
    public GameObject shotgunSpawn;
    public GameObject pistol;
    public GameObject pistolSpawn;
    public GameObject staff;
    public GameObject staffSpawn;
    public GameObject laser;
    public GameObject laserSpawn;

    void Update ()
    {
        if (!ak.activeSelf)
        {
            StartCoroutine(AKRespawn());
        }
        if (!shotgun.activeSelf)
        {
            StartCoroutine(ShotgunRespawn());
        }
        if (!pistol.activeSelf)
        {
            StartCoroutine(PistolRespawn());
        }
        if (!staff.activeSelf)
        {
            StartCoroutine(StaffRespawn());
        }
        if (!laser.activeSelf)
        {
            StartCoroutine(LaserRespawn());
        }
    }

    IEnumerator AKRespawn()
    {
        yield return new WaitForSeconds(respawnTime);
        ak.transform.position = akSpawn.transform.position;
        ak.SetActive(true);
    }

    IEnumerator ShotgunRespawn()
    {
        yield return new WaitForSeconds(respawnTime);
        shotgun.transform.position = shotgunSpawn.transform.position;
        shotgun.SetActive(true);
    }

    IEnumerator PistolRespawn()
    {
        yield return new WaitForSeconds(respawnTime);
        pistol.transform.position = pistolSpawn.transform.position;
        pistol.SetActive(true);
    }
    IEnumerator StaffRespawn()
    {
        yield return new WaitForSeconds(respawnTime);
        staff.transform.position = staffSpawn.transform.position;
        staff.SetActive(true);
    }
    IEnumerator LaserRespawn()
    {
        yield return new WaitForSeconds(respawnTime);
        laser.transform.position = laserSpawn.transform.position;
        laser.SetActive(true);
    }
}
