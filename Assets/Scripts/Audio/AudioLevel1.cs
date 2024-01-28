using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiioLevel1 : MonoBehaviour
{
    private FMOD.Studio.EventInstance soundtrackInstance;

    // Start is called before the first frame update
    void Start()
    {
        soundtrackInstance = FMODUnity.RuntimeManager.CreateInstance("event:/Shepherd");

        soundtrackInstance.start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
