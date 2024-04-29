using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public Animator animator;
    

    void Start()
    {
        DoorOpening();
    }

   void DoorOpening()
    {
        if (Button1 && Button2 && Button3 == true)
        {
            animator.SetTrigger("Open");
        }
        else
        {
            
        }
    }
}
