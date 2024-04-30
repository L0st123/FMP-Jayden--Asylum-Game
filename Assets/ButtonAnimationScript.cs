using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationScript : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        ButtonPress();
    }

    void ButtonPress()
    {
        if (Input.GetKey("e"))
        {
            animator.SetBool("push", true);
            Debug.Log("Pushed button start animation");
        }
        else
        {
            animator.SetBool("push", false);
        }

    }
    

}
