using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosTermino : MonoBehaviour
{
    public static DatosTermino instancia;
    public string HoraTermino;


    void Start()
    {

    }

    void Awake()
    {
        instancia = this;
    }

    void Update()
    {

    }
    public void GenerarHoraTermino()
    {
        HoraTermino = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
}
