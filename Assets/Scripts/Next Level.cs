using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public UnityEngine.UI.Image[] stars;
    public Sprite[] coloredStars;

    public void SiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }

    public IEnumerator StarCounting(int nStars, int level)
    {
        switch (level)
        {
            case 1:
                Stars.starsLevel1 = nStars;
                break;
            case 2:
                Stars.starsLevel2 = nStars;
                break;
            case 3:
                Stars.starsLevel3 = nStars;
                break;
        }
        for (int i = 0; i < nStars; ++i)
        {
            stars[i].sprite = coloredStars[i];
            yield return new WaitForSeconds(1f);
        }
    }
}

public class Stars
{
    static public int starsLevel1 = 0;
    static public int starsLevel2 = 0;
    static public int starsLevel3 = 0;
}
