using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{

    public static HUD instance;


    private void Awake()
    {
        instance = this;

    }

    public void Salir()
    {
        SceneManager.LoadScene("Log-In");
        // Investigar como descargar la escena actual
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
        // Investigar como descargar la escena actual
    }

    public void Reanudar()
    {
        MenuPausa.instance.Pausar();
    }

}
