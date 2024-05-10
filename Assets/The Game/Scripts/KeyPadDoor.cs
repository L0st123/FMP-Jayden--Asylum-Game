using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadDoor : MonoBehaviour
{
    Animator anim;
    public GameObject keypad;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // check for keypad success
        if( keypad.GetComponent<Keypad>().accessWasGranted == true )
        {
            anim.SetBool("Open", true);
        }
        
    }
}
