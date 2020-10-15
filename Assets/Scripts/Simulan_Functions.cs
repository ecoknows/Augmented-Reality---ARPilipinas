using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Simulan_Functions : MonoBehaviour
{
    // Start is called before the first frame update
    public int BUTTON_TYPE;
    public Animator oppositeBtn;
    public VideoController vc;

    public void ModuleStart()
    {
        if (vc != null)
            if (!vc.isFunction)
                return;
        switch (BUTTON_TYPE)
        {
            case 0: // SIMULAN
                gameObject.SetActive(false);
                transform.parent.GetChild(1).gameObject.SetActive(true);
                break;
            case 1:// SUSUNOD
                transform.parent.parent.GetComponent<ItemsScript>().Current_Index++;
                int inc = transform.parent.parent.GetComponent<ItemsScript>().Current_Index;
                transform.parent.parent.GetChild(inc).gameObject.SetActive(true);
                transform.parent.gameObject.SetActive(false);
                break;
            case 2:// BALIKAN
                transform.parent.parent.GetComponent<ItemsScript>().Current_Index--;
                int dec = transform.parent.parent.GetComponent<ItemsScript>().Current_Index;
                transform.parent.parent.GetChild(dec).gameObject.SetActive(true);
                transform.parent.gameObject.SetActive(false);
                break;
        }
    }

    private void OnEnable()
    {
        if(BUTTON_TYPE == 1 || BUTTON_TYPE == 2)
        {
            transform.GetComponent<Animator>().SetTrigger("Simulan");
        }
    }

    public void OpossiteAnim()
    {
        if(oppositeBtn != null)
            oppositeBtn.SetTrigger("Exit");
    }

}
