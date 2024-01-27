using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public GameObject levelPassedScreen;
    public GameObject levelNotPassedScreen;

    public AudioManager doorSound;
    public SafeArea safeArea;
    
   // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponentsInChildren<Animator>()[0].Play("Door");
            GetComponentsInChildren<Animator>()[1].Play("Door");
            if(safeArea.numberSheepInside / safeArea.totalSheep < 0.5f)
                levelNotPassedScreen.SetActive(true);
            // else
            //     levelPassedScreen safeArea.numberSheepInside / safeArea.totalSheep;
        }
    }
}
