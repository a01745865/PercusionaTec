using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
// Autores: Jose Luis Madrigal, Erika Marlene Garcia, Cesar Emiliano Palome, Jose Angel Garcia
// Clase para hacer conexion web con unity para registrar datos ingresados

public class RegistrarDatos : MonoBehaviour
{
    public TextMeshProUGUI resultado;

    //Los datos de entrada
    public TMP_InputField textoUsuario;
    public TMP_InputField textoNombre;
    public TMP_InputField textoCiudad;
    public TMP_InputField textoMail;
    public TMP_InputField textoContrasena;
    public TMP_InputField textoFechaNaci;
    public TMP_InputField textoNacionalidad;

    //Enviar los datos al servidor(click del boton)
    public void EnviarDatos()
    {
        StartCoroutine(SubirDatos());
    }

    private IEnumerator SubirDatos()
    {
        //Recuperar los datos
        string usuario = textoUsuario.text;
        string nombre = textoNombre.text;
        string ciudad = textoCiudad.text;
        string mail = textoMail.text;
        string contrasena = textoContrasena.text;
        string fechaNaci = textoFechaNaci.text;
        string nacionalidad = textoNacionalidad.text;
        //Crear un objeto con los datos
        WWWForm forma = new WWWForm();
        forma.AddField("usuario", usuario);
        forma.AddField("nombre", nombre);
        forma.AddField("ciudad", ciudad);
        forma.AddField("mail", mail);
        forma.AddField("contrasena", contrasena);
        forma.AddField("fechaNaci", fechaNaci);
        forma.AddField("nacionalidad", nacionalidad);

        UnityWebRequest request = UnityWebRequest.Post("link de api hecha con lo de marciano", forma);
        yield return request.SendWebRequest();
        //....despues de cierto tiempo
        if (request.result == UnityWebRequest.Result.Success)
        {
            string texto = request.downloadHandler.text;
            resultado.text = texto;
        }
        else
        {
            resultado.text = "Error: " + request.ToString();
        }
    }
}
