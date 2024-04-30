using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton : MonoBehaviour
{
    public bool button;
    public Animator animator;
    

    private void Start()
    {

        button = false; 
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Button " + gameObject.name + " is pressed");
        button = true;
        

    }
  
    
}
