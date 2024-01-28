using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public FMOD.Studio.EventInstance sheepInstace;
    public FMOD.Studio.EventInstance shepherdInstance;
    private FMOD.Studio.EventInstance forestAmbience;


    //RIVER ON: NIVEL 3
    // private FMOD.Studio.EventInstance riverInstance;

    void Start()
    {
        sheepInstace = FMODUnity.RuntimeManager.CreateInstance("event:/Sheep");
        shepherdInstance = FMODUnity.RuntimeManager.CreateInstance("event:/Shepherd");
        // riverInstance = FMODUnity.RuntimeManager.CreateInstance("event:/River");
        forestAmbience = FMODUnity.RuntimeManager.CreateInstance("event:/SoundtrackNoWolf");

        forestAmbience.start();
        sheepInstace.start();
        shepherdInstance.start();
        // riverInstance.start();
    }
    public void PlaySound(string path)
    {
        FMODUnity.RuntimeManager.PlayOneShot(path, GetComponent<Transform>().position);
    }

    void Update()
    {
    
    }
}
