using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLevel2 : MonoBehaviour
{
    // private FMOD.Studio.EventInstance soundtrackInstance;
    private FMOD.Studio.EventInstance windInstance;
    // Start is called before the first frame update
    void Start()
    {
        // soundtrackInstance = FMODUnity.RuntimeManager.CreateInstance("event:/SoundtrackNoWolf");
        windInstance = FMODUnity.RuntimeManager.CreateInstance("event:/WindAmbience");
        
        // soundtrackInstance.start();
        windInstance.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
