using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulanClick : MonoBehaviour
{
    public Animator anim;
    public Animator text;
    public Animator vid;
    public VideoController vc; 
    void OnMouseDown()
    {
        anim.SetTrigger("Done");


        if (text != null)
        {
            text.SetTrigger("End");
        }
        if (vid != null && vc != null)
        {
            if (!vc.isSusunod)
            {
                vc.vp.Stop();
                vid.SetTrigger("FinishVid");
                vc.isSusunod = true;
                vc.type = transform.parent.GetComponent<Simulan_Functions>().BUTTON_TYPE;
            }
           
        }
    }
}
