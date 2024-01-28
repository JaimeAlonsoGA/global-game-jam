using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class random2 : MonoBehaviour
{
    public Image[] imagesDialog;
    public TextMeshProUGUI[] textsDialog;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomDialogs());
    }

    IEnumerator RandomDialogs()
    {
        yield return new WaitForSeconds(15f);
        while(true)
        {
            int currentDialog = Random.Range(0, 6);
            imagesDialog[currentDialog].enabled = true;
            textsDialog[currentDialog].enabled = true;
            yield return new WaitForSeconds(Random.Range(10f, 15f));

            /*yield return new WaitForSeconds(1.2f);
            imagesDialog[0].enabled = false;
            textsDialog[0].enabled = false;

            yield return new WaitForSeconds(1.2f);
            imagesDialog[1].enabled = false;
            textsDialog[1].enabled = false;

            yield return new WaitForSeconds(1.2f);
            imagesDialog[2].enabled = false;
            textsDialog[2].enabled = false;*/
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
