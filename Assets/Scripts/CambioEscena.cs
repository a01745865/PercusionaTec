using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    //Cambia la escena una vex apretado el boton, el boton va a saber a que escena cambiará
    public void LoadSceneInicio()
    {
        SceneManager.LoadScene("ciudad");
    }
    public void LoadSceneScores()
    {
        SceneManager.LoadScene("ciudad");
    }
    public void LoadSceneOptions()
    {
        SceneManager.LoadScene("Setting");
    }

    public void LoadSceneTambor()
    {
        SceneManager.LoadScene("ExplicacionTambor");
    }

    public void LoadSceneConga()
    {
        SceneManager.LoadScene("ExplicacionConga");
    }

    public void LoadSceneMaracas()
    {
        SceneManager.LoadScene("ExplicacionMaracas");
    }

    public void LoadSceneXilofono()
    {
        SceneManager.LoadScene("ExplicacionXilofono");
    }

    public void LoadNivel1_Tambor()
    {
        SceneManager.LoadScene("Tambor");
    }

    public void LoadNivel1_Conga()
    {
        SceneManager.LoadScene("Conga");
    }

    public void LoadNivel1_Maracas()
    {
        SceneManager.LoadScene("Maracas");
    }

    public void LoadNivel1_Xilofono()
    {
        SceneManager.LoadScene("Xilofono");
    }
}
