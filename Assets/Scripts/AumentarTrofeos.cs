using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AumentarTrofeos : MonoBehaviour
{
    public GameObject tambor;
    public GameObject congas;
    public GameObject maracas;


    public void Awake()
    {
        int trofeos = PlayerPrefs.GetInt("trofeo");
        switch (trofeos)
        {
            case 3:
                maracas.SetActive(true);
                congas.SetActive(true);
                tambor.SetActive(true);
                print("Maracas");
                break;
            case 2:
                congas.SetActive(true);
                tambor.SetActive(true);
                print("Congas" + trofeos.ToString());
                break;
            case 1:
                tambor.SetActive(true);
                print("Tambor");
                break;
            case 0:
                print("Nada");
                break;
        }
    }



}
