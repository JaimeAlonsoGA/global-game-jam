using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 40;
    public GameObject wolf;
    public AudioManager wolfSound;
    bool isWolfAlive = false;

    // Start is called before the first frame update
    void Start()
    {
        wolfSound.PlaySound("event:/WolfLevel");
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
            timeRemaining -= Time.deltaTime;
        else if (!isWolfAlive)
        {
            isWolfAlive = true;
            wolf.SetActive(true);
            wolfSound.PlaySound("event:/SpawnWolf");
        }
    }
}
