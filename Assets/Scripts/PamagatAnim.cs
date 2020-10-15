using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PamagatAnim : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Animator>().SetTrigger("Start");
    }
}
