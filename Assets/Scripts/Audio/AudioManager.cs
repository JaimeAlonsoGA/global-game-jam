using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public void PlaySound(string path)
    {
        FMODUnity.RuntimeManager.PlayOneShot(path, GetComponent<Transform>().position);
    }
    
    void Start()
    {
        PlaySound("event:/SoundtrackNoWolf");
        PlaySound("event:/ForestAmbience");
    }

    void Update()
    {
        
    }
}
