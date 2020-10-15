using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAppear : MonoBehaviour
{
    public GameObject object1, object2;
    private bool status = false;
    void OnMouseDown()
    {
        if (!status)
        {
            object1.SetActive(false);
            object2.SetActive(false);
            status = true;      
        }
        else
        {
            object1.SetActive(true);
            object2.SetActive(true);
            status = false;
        }
    }
}
