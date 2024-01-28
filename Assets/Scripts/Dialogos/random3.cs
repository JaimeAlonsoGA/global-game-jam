using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class random3 : MonoBehaviour
{
    public float timeRemaining = 1.6f;

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
            yield return new WaitForSeconds(Random.Range(10f, 15f));
            int currentDialog = Random.Range(0, 4);
            imagesDialog[currentDialog].enabled = true;
            textsDialog[currentDialog].enabled = true;

            yield return new WaitForSeconds(1.2f);
            imagesDialog[currentDialog].enabled = false;
            textsDialog[currentDialog].enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

}
