using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountVoiceStart : MonoBehaviour
{
    public int NUM = 0;
    private void OnEnable()
    {
        GetComponent<AudioSource>().Play();
        if(NUM == 0)
        {
            transform.parent.parent.GetComponent<AudioSource>().Play();
        }
    }
}
