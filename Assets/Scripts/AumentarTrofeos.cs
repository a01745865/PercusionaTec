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


    public void masTrofeos()
    {
        int trofeos = PlayerPrefs.GetInt("trofeo");
        switch (trofeos)
        {
            case 2:
                maracas.SetActive(true);
                break;
            case 1:
                congas.SetActive(true);
                break;
            case 0:
                tambor.SetActive(true);
                break;

        }
    }



}
