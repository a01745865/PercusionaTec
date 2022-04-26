using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElegirPersonaje : MonoBehaviour
{
    private int eleccion;
    
    public void EstablecerEleccion(string nombrePersonaje)
    {
        if(nombrePersonaje == "chica")
        {
            eleccion = 1;
        }
        else if(nombrePersonaje == "dino")
        {
            eleccion = 2;
        }
        else
        {
            eleccion = 3;
        }
    }
}
