using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnvCiudadDatos : MonoBehaviour
{
    public string HoraInicio;
    public string HoraFin;
    public string usuario;
    public string id_partida;
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
        id_partida = PlayerPrefs.GetString("idPartida");
        //Crear un objeto con los datos
        WWWForm formaDatosTermino = new WWWForm();
        formaDatosTermino.AddField("usuario", usuario);
        formaDatosTermino.AddField("horaTermino", HoraFin);

        string URLactualizarHoraTermino = "http://localhost:3000/partidas/" + id_partida;
        UnityWebRequest request = UnityWebRequest.Post(URLactualizarHoraTermino, formaDatosTermino);
        yield return request.SendWebRequest();
    }
}
