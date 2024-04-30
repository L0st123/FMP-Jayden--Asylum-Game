using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public Animator animator;
    
    

    void Update()
    {
        DoorOpening();
    }

   void DoorOpening()
    {

        if ( button1.GetComponent<CubeButton>().button && 
            button2.GetComponent<CubeButton>().button && 
            button3.GetComponent<CubeButton>().button)
        {
            animator.SetTrigger("Open");
            Debug.Log("Opening Door");
        }
        else
        {
           
        }
    }
}
