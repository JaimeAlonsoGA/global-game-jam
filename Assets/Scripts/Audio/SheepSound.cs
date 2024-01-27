using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSound : MonoBehaviour
{
    private FMOD.Studio.EventInstance sheepInstace;

    // Start is called before the first frame update
    void Start()
    {
        sheepInstace = FMODUnity.RuntimeManager.CreateInstance("event:/Sheep");
        sheepInstace.start();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
