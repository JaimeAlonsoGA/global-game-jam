using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUno : MonoBehaviour
{
    public Image[] stars1;
    public Image[] stars2;
    public Image[] stars3;
    public Sprite[] coloredStars;

    public void Jugar1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Jugar2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Jugar3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    void Start()
    {
        for(int i = 0; i < Stars.starsLevel1; ++i)
        {
            stars1[i].sprite = coloredStars[i];
        }
        for(int i = 0; i < Stars.starsLevel2; ++i)
        {
            stars2[i].sprite = coloredStars[i];
        }
        for(int i = 0; i < Stars.starsLevel3; ++i)
        {
            stars3[i].sprite = coloredStars[i];
        }
    }

    public void Salir() {

        Debug.Log("Salir...");
        Application.Quit();
    }
}
