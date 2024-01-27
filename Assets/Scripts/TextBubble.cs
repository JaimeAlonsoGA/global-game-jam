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
        timeNextDialog = Random.Range(15f, 30f);

        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {
        // enable 1

        yield return new WaitForSeconds(2.5f);
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

        yield return new WaitForSeconds(1f);
        imagesDialog[2].enabled = true;
        textsDialog[2].enabled = true;

        yield return new WaitForSeconds(2f);
        imagesDialog[2].enabled = false;
        textsDialog[2].enabled = false;

        yield return new WaitForSeconds(1f);
        imagesDialog[3].enabled = true;
        textsDialog[3].enabled = true;

        yield return new WaitForSeconds(2f);
        imagesDialog[3].enabled = false;
        textsDialog[3].enabled = false;

        yield return new WaitForSeconds(1f);
        imagesDialog[4].enabled = true;
        textsDialog[4].enabled = true;

        yield return new WaitForSeconds(1.2f);
        imagesDialog[4].enabled = false;
        textsDialog[4].enabled = false;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
