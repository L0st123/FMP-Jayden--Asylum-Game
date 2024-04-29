using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton1 : MonoBehaviour
{
    public Animator myDoor;
    public bool Button1;

    private void OnMouseUpAsButton()
    {
        Debug.Log("Button is pressed");
        Button1 = true;

        
    }
    
    
}
