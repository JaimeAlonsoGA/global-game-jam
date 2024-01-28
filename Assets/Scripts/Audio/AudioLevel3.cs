using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLe : MonoBehaviour
{
    private FMOD.Studio.EventInstance soundtrackInstance;
    private FMOD.Studio.EventInstance riverInstance;
    // Start is called before the first frame update
    void Start()
    {
        soundtrackInstance = FMODUnity.RuntimeManager.CreateInstance("event:/SoundtrackWolf");
        riverInstance = FMODUnity.RuntimeManager.CreateInstance("event:/River");

        soundtrackInstance.start();
        riverInstance.start();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
