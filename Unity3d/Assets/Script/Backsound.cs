using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backsound : MonoBehaviour
{
    public AudioSource backsound;

    public void backsoundOnOff()
    {
        AudioSource bgsound = backsound.GetComponent<AudioSource>();

        if(bgsound.mute == true)
        {
            bgsound.mute = false;
        }else {
            bgsound.mute = true;
        }
    }
}
