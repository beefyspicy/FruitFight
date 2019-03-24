using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Round5 : MonoBehaviour
{
    public Text round;

    void Start()
    {
        round.text = "";
        StartCoroutine(RoundStart());
    }

    IEnumerator RoundStart()
    {
        yield return new WaitForSeconds(0.5f);
        round.text = "Final Round";
        yield return new WaitForSeconds(2f);
        round.text = "";
    }
}
