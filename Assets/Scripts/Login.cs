using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
// Autores: Jose Luis Madrigal, Erika Marlene Garcia, Cesar Emiliano Palome, Jose Angel Garcia
// Clase para hacer conexion web con unity para mandar datos igresados en login 
public class Login : MonoBehaviour
{
    public TextMeshProUGUI resultado;

    //Los datos de entrada
    public TMP_InputField textoUsuario;
    public TMP_InputField textoContrasena;

    //Enviar los datos al servidor(click del boton)
    public void EnviarDatos()
    {
        StartCoroutine(SubirDatos());
    }

    private IEnumerator SubirDatos()
    {
        //Recuperar los datos
        string usuario = textoUsuario.text;
        string contrasena = textoContrasena.text;
        //Crear un objeto con los datos
        WWWForm forma = new WWWForm();
        forma.AddField("usuario", usuario);
        forma.AddField("contrasena", contrasena);
        string URLinicioSesion = "localhost:3000/jugador/" + usuario + "/" + contrasena;
        UnityWebRequest request = UnityWebRequest.Get(URLinicioSesion);
        yield return request.SendWebRequest();
        //....despues de cierto tiempo
        if (request.result == UnityWebRequest.Result.Success)
        {
            string usuario = request.downloadHandler.text; ;
            PlayerPrefs.SetString("usuario", usuario);
            PlayerPrefs.Save(); 

            SceneManager.LoadScene("Inicio");
        }
        else
        {
            resultado.text = "Error: El usuario no esta ingresado o la contraseña es incorrecta";
        }
    }

    public void registrar()
    {
        SceneManager.LoadScene("RegistroDatos");
        // Investigar como descargar la escena actual
    }
}
