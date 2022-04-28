using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
 * Script que detecta la secuencia correcta
 * Autores: Erika Marlene García Sánchez, César Emiliano Palome Luna, Jose Angel Garcia Gomez y José Luis Madrigal Sánchez
 */
public class cambionivelTAMBOR : MonoBehaviour
{
    public static cambionivelTAMBOR instance;

    

    public TextMeshProUGUI txtPuntos;
    public TextMeshProUGUI txtErrores;
   
    public int errores =  0;
    public int puntos = 0;

    public int i = 0;

    public string[] patron;


    void Start()
    {
       errores = PlayerPrefs.GetInt("errores");
        puntos = PlayerPrefs.GetInt("puntos");

        patron = new string[10];
        patron[0] = ("S");
        patron[1] = ("D");
        patron[2] = ("A");
        patron[3] = ("D");
        patron[4] = ("D");
        patron[5] = ("A");
        patron[6] = ("D");
        txtPuntos.text = puntos.ToString();
        txtErrores.text = errores.ToString();

    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (patron[i] == "A")
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
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (patron[i] == "D")
            {
                puntos = puntos + 1;
                txtPuntos.text = puntos.ToString();
                i = i + 1;
                if (i > 6)
                {
                    
                      
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

        SceneManager.LoadScene("DRUMNivelExitoso");
    }
}
