using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript2 : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {
        ButtonAudio();
    }
    public void ButtonAudio()
    {
        source.PlayOneShot(clip);
        StartCoroutine(_ButtonAudio());
    }


    private IEnumerator _ButtonAudio()
    {
        yield return new WaitForSeconds(1.0f);
        
        

    }

    
}
