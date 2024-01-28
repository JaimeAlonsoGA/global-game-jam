using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Doors : MonoBehaviour
{
    public GameObject levelPassedScreen;
    public GameObject levelNotPassedScreen;
    public AudioManager doorSound;
    public SafeArea safeArea;
    AudioManager audioInstance;
    public bool doorClosed = false;

    // Start is called before the first frame update
    void Start()
    {
        doorClosed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.GetButtonDown("Jump")) && doorClosed == false)
        {
            GetComponentsInChildren<Animator>()[0].Play("Door");
            GetComponentsInChildren<Animator>()[1].Play("Door");
            Invoke("StartEnd", 1f);
            doorClosed = true;
            doorSound.PlaySound("event:/Door");
        }

        if (safeArea.totalSheepRemaining == 0)
        {
            levelNotPassedScreen.SetActive(true);
        }
    }

    void StartEnd()
    {
        if((float)safeArea.numberSheepInside / (float)safeArea.totalSheep < 0.5f)
        {
            levelNotPassedScreen.SetActive(true);
        }

        else
        {
            levelPassedScreen.SetActive(true);
            int numberStars = 1;
            if((float)safeArea.numberSheepInside / (float)safeArea.totalSheep >= 0.75f)
                numberStars++;
            if((float)safeArea.numberSheepInside / (float)safeArea.totalSheep == 1f)
                numberStars++;

            StartCoroutine(levelPassedScreen.GetComponent<NextLevel>().StarCounting(numberStars, SceneManager.GetActiveScene().buildIndex));
        }
    }
}
