using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public float timeRemaining = 0;
    public int second = 0;
    List<Transform> popUpObjs;
    const int duration = 1;

    void Start()
    {

        popUpObjs = new List<Transform>();
        foreach (Transform obj in transform)
        {
            popUpObjs.Add(obj);
        }
    }
    void Update()
    {
        if (timeRemaining >= 0 && second <= 6*duration)
        {
            timeRemaining += Time.deltaTime;
            int temp = Mathf.FloorToInt(timeRemaining % 60)-10;
 
            switch (temp)
            {
                case 0:
                    popUpObjs[0].gameObject.SetActive(true);
                    break;
                case 1*duration:
                    popUpObjs[0].gameObject.SetActive(false);
                    popUpObjs[1].gameObject.SetActive(true);
                    break;
                case 2*duration:
                    popUpObjs[1].gameObject.SetActive(false);
                    popUpObjs[2].gameObject.SetActive(true);
                    break;
                case 3*duration:
                    popUpObjs[2].gameObject.SetActive(false);
                    popUpObjs[3].gameObject.SetActive(true);
                    break;
                case 4*duration:
                    popUpObjs[3].gameObject.SetActive(false);
                    popUpObjs[4].gameObject.SetActive(true);
                    break;
                case 5 * duration:
                    popUpObjs[4].gameObject.SetActive(false);
                    popUpObjs[5].gameObject.SetActive(true);
                    break;
                case 6 * duration:
                    transform.gameObject.SetActive(false);
                    transform.parent.GetChild(0).transform.gameObject.SetActive(true);
                    break;
            }
        }

    }
}
