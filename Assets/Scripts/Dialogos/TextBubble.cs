using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBubble : MonoBehaviour
{
    float timeNextDialog;

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

        yield return new WaitForSeconds(1f);
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

        yield return new WaitForSeconds(1.8f);
        imagesDialog[3].enabled = false;
        textsDialog[3].enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
