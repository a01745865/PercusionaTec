using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnvCiudadDatos : MonoBehaviour
{
    public string HoraInicio;
    public string HoraFin;
    public string usuario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enviar()
    {
        StartCoroutine(DatosPartidas());
    }
    private IEnumerator DatosPartidas()
    {
        HoraInicio = PlayerPrefs.GetString("hora_conecta_partida");
        HoraFin = DatosTermino.instancia.HoraTermino;
        usuario = PlayerPrefs.GetString("usuario");
        print(HoraInicio);
        print(HoraFin);
        print(usuario);
        WWWForm formaPartida = new WWWForm();
        formaPartida.AddField("usuario", usuario);
        formaPartida.AddField("inicio", HoraInicio);
        formaPartida.AddField("fin", HoraFin);
        string URLDatosPartida = "localhost:3000/partidas/";
        UnityWebRequest request = UnityWebRequest.Post(URLDatosPartida, formaPartida);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.Success)
        {
            string texto = request.downloadHandler.text;
            print(texto);
        }
        else
        {
            print("No se ingreso nada");
        }
    }
}
