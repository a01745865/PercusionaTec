using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPersonaje : MonoBehaviour
{
    public GameObject chica;
    public GameObject dino;
    public GameObject chico;


    void Start()
    {
        //int eleccion = ElegirPersonaje.instancia.eleccion;
        int eleccion = PlayerPrefs.GetInt("eleccion");
        if(eleccion == 1)
        {
            chica.SetActive(true);
        }
        else if(eleccion == 2)
        {
            dino.SetActive(true);
        }
        else if(eleccion == 3)
        {
            chico.SetActive(true);
        }
    }

}
