using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject BotonPausa;

    [SerializeField] public GameObject MenuPausa;
  public void Pausa()
    {
        Time.timeScale = 0f;
        BotonPausa.SetActive(false);
        MenuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time .timeScale = 1f;
        BotonPausa .SetActive(true);
        MenuPausa .SetActive(false);
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}
