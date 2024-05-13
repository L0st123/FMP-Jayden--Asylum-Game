using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public Animator animator;
    public AudioSource OpenDoorSound;

    bool soundPlayed;

    private void Start()
    {
        soundPlayed = false;

    }


    void Update()
    {
        DoorOpening();


        if( Input.GetKeyDown("y") )
        {
            OpenDoorSound.Play();
        }
    }

   void DoorOpening()
    {

        if ( button1.GetComponent<CubeButton>().button && 
            button2.GetComponent<CubeButton>().button && 
            button3.GetComponent<CubeButton>().button)
        {
            if( soundPlayed==false)
            {
                animator.SetBool("Open", true);
                Debug.Log("Opening Door");
                OpenDoorSound.Play();
                soundPlayed = true;
            }


        }
        else
        {
           //animator.SetBool("Open", false);
            
        }
    }
  
}
