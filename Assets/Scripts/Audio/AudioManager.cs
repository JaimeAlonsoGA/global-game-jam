using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private FMOD.Studio.EventInstance sheepInstace;
    private FMOD.Studio.EventInstance shepherdInstance;
    public void PlaySound(string path)
    {
        FMODUnity.RuntimeManager.PlayOneShot(path, GetComponent<Transform>().position);
    }
    
    void Start()
    {
        sheepInstace = FMODUnity.RuntimeManager.CreateInstance("event:/Sheep");
        shepherdInstance = FMODUnity.RuntimeManager.CreateInstance("event:/Shepherd");

        PlaySound("event:/SoundtrackNoWolf");
        PlaySound("event:/ForestAmbience");
        sheepInstace.start();
        shepherdInstance.start();

    }

    void Update()
    {
        
    }
}
