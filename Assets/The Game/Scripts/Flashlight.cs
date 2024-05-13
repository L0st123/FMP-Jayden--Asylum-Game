using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject FlashlightLight;
    private bool flashlightEnabled = false;
    public AudioSource flashlightSource;
    // Start is called before the first frame update
    void Start()
    {
        FlashlightLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashlightEnabled == false)
            {
                flashlightSource.Play();    
                FlashlightLight.gameObject.SetActive(true);
                flashlightEnabled = true;
            }
            else
            {
                FlashlightLight.gameObject.SetActive(false);
                flashlightEnabled = false;
            }
        }
       
    }
}
