using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CiudadDatos : MonoBehaviour
{
    public static CiudadDatos instancia;
    public string tiempoConecta;
    public DateTime tiempoDesconecta;
    
    // Start is called before the first frame update
    void Start()
    {
        tiempoConecta = dateOnly.ToString("MM/dd/yyyy HH:mm");
        print(tiempoConecta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
