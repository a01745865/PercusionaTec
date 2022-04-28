using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
 * Script que detecta la secuencia correcta del tambor
 * Autores: Erika Marlene García Sánchez, César Emiliano Palome Luna, Jose Angel Garcia Gomez y José Luis Madrigal Sánchez
 */
public class DetectaTeclas2 : MonoBehaviour
{

    public int errores = 0;
    public int puntos = 0;

    public TextMeshProUGUI txtPuntos;
    public TextMeshProUGUI txtErrores;


    public int i = 0;

    public string[] patron;


    void Start()
    {


        patron = new string[9];
        patron[0] = ("S");
        patron[1] = ("M");
        patron[2] = ("Z");
        patron[3] = ("M");
        patron[4] = ("M");
        patron[5] = ("Z");
        patron[6] = ("M");
        patron[7] = ("Z");
        patron[8] = ("M");
        PlayerPrefs.SetInt("puntos", puntos);
        PlayerPrefs.SetInt("errores", errores);
        txtPuntos.text = puntos.ToString();
        txtErrores.text = errores.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (patron[i] == "Z")
            {
                puntos = puntos + 1;
                txtPuntos.text = puntos.ToString();
                i = i + 1;
                
            }
            else
            {
                errores = errores + 1;
                txtErrores.text = errores.ToString();
            }

        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            if (patron[i] == "M")
            {
                puntos = puntos + 1;
                txtPuntos.text = puntos.ToString();
                i = i + 1;
                if (i > 8)
                {
                    PlayerPrefs.SetInt("puntos", puntos);
                    PlayerPrefs.SetInt("errores", errores);
                    PlayerPrefs.Save(); // Escribe en Disco     
                    esperarscene();
                }
            }
            else
            {
                errores = errores + 1;
                txtErrores.text = errores.ToString();
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (patron[i] == "S")
            {
                i = i + 1;
            }
        }

    }

    void esperarscene()
    {
        StartCoroutine(next_scene());
    }

    private IEnumerator next_scene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("CongaNivelExitoso");
    }
}

