using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    //Cambia la escena una vex apretado el boton, el boton va a saber a que escena cambiará
    public void LoadScene(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
