using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 40;
    public GameObject wolf;
    private void Instantiate(GameObject wolf, Vector3 spawn)
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
            timeRemaining -= Time.deltaTime;
        else {
            Instantiate(wolf, new Vector3(0, 0, 0));
        }
    }
}
