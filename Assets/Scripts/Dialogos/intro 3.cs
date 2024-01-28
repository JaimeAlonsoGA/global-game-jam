using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class intro3 : MonoBehaviour
{
    public Image[] imagesDialog;
    public TextMeshProUGUI[] textsDialog;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {
        yield return new WaitForSeconds(2f);
        imagesDialog[0].enabled = true;
        textsDialog[0].enabled = true;

        yield return new WaitForSeconds(1.2f);
        imagesDialog[0].enabled = false;
        textsDialog[0].enabled = false;

        yield return new WaitForSeconds(0.8f);
        imagesDialog[1].enabled = true;
        textsDialog[1].enabled = true;

        yield return new WaitForSeconds(1.2f);
        imagesDialog[1].enabled = false;
        textsDialog[1].enabled = false;

        yield return new WaitForSeconds(0.8f);
        imagesDialog[2].enabled = true;
        textsDialog[2].enabled = true;

        yield return new WaitForSeconds(2f);
        imagesDialog[2].enabled = false;
        textsDialog[2].enabled = false;

        yield return new WaitForSeconds(0.8f);
        imagesDialog[3].enabled = true;
        textsDialog[3].enabled = true;

        yield return new WaitForSeconds(2f);
        imagesDialog[3].enabled = false;
        textsDialog[3].enabled = false;

        yield return new WaitForSeconds(0.8f);
        imagesDialog[4].enabled = true;
        textsDialog[4].enabled = true;

        yield return new WaitForSeconds(1f);
        imagesDialog[4].enabled = false;
        textsDialog[4].enabled = false;

        yield return new WaitForSeconds(0.8f);
        imagesDialog[5].enabled = true;
        textsDialog[5].enabled = true;

        yield return new WaitForSeconds(1f);
        imagesDialog[5].enabled = false;
        textsDialog[5].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
