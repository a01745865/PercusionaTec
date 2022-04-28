using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CiudadDatos : MonoBehaviour
{
    public static CiudadDatos instancia;
    public string tiempoConecta;

    //"MM/dd/yyyy HH:mm"
    // Start is called before the first frame update
    void Start()
    {
        tiempoConecta = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
    void Awake()
    {
        instancia = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
