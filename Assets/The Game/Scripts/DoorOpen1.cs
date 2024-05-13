using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen1 : MonoBehaviour
{

    public Animator animator;
    public bool door;
    public AudioSource DoorOpen; 
    
    

    void Start()
    {
        door = false;
        animator.SetBool("Open", false);
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log( gameObject.name + " is pressed");
        door = true;
        animator.SetBool("Open", true);
        DoorOpen.Play();

    }


}
