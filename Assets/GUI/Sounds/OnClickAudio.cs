using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

     void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            source.Play();
        }
    }
}

