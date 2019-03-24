using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleAnim : MonoBehaviour {

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRunnin", true);
        }
        else
        {
            anim.SetBool("isRunnin", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            anim.SetTrigger("jump");
        }
    }
}
