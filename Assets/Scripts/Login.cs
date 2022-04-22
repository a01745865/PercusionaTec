using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
// Autor: Jose Luis Madrigal
// Clase para hacer conexion web con unity para login
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
