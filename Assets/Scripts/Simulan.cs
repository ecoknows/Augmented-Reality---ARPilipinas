using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Simulan : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public Animator simulan;
    private bool isSimulan = false;
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is fou

            simulan.SetTrigger("Simulan");
            isSimulan = true;
        }
        else
        {
            // Stop audio when target is lost
            if (isSimulan)
            {
                simulan.SetTrigger("Hinto");
                isSimulan = false;
            }
        }
    }
}
    
