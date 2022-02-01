using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteManager : MonoBehaviour
{
    private bool isMuted;

    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;
    }

    public void MutedPressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
   //mute analytics?
   

    }
}
