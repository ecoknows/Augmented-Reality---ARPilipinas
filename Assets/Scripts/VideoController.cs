using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer vp;
    private bool isVideoPlaying = false;
    public bool isSusunod = false;
    public bool isFunction = false;
    public int type = -1;
     void Start()
    {
        vp.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        gameObject.GetComponent<Animator>().SetTrigger("FinishVid");
    }
    public void NextItem()
    {
        if (isSusunod)
        {
            switch (type)
            {
                case 1:
                    transform.parent.gameObject.GetComponent<ItemsScript>().Current_Index++;
                    int latest_index = transform.parent.gameObject.GetComponent<ItemsScript>().Current_Index;
                    GameObject latestItem = transform.parent.GetChild(latest_index).gameObject;
                    gameObject.SetActive(false);
                    latestItem.SetActive(true);
                    break;
                case 2:
                    transform.parent.gameObject.GetComponent<ItemsScript>().Current_Index--;
                    int latest_index_back = transform.parent.gameObject.GetComponent<ItemsScript>().Current_Index;
                    GameObject latestItem_back = transform.parent.GetChild(latest_index_back).gameObject;
                    gameObject.SetActive(false);
                    latestItem_back.SetActive(true);
                    break;
            }
        }

        isSusunod = true;
        isFunction = true;
        isVideoPlaying = false;
    }
    public void vidPlay()
    {
        if (vp != null) vp.Play();
    }

    public void vidStop()
    {
        if (vp != null) vp.Stop();
    }

    private void OnEnable()
    {
        if (!isVideoPlaying)
        {
            transform.GetComponent<Animator>().SetTrigger("StartVid");
            isVideoPlaying = true;
            isSusunod = false;
            isFunction = false;
        }
    }

}

