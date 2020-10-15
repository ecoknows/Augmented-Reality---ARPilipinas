using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{
    AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    /*
    private void OnEnable()
    {
        GetComponent<Animator>().SetTrigger("Start");
    }*/
    public void Speak()
    {
        audio.Play();
        //StartCoroutine(waitForSound());
    }
    private void OnEnable()
    {
        GetComponent<Animator>().SetTrigger("Start");
    }
}
