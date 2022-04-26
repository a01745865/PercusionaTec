using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempodevida : MonoBehaviour
{
    public static tiempodevida instancia;

    public float tiempoDeVida;
    // Start is called before the first frame update
    
    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

    void Awake()
    {
        instancia = this;
    }

    private void onDestroy()
    {
        print("Hola");
        STICK2.instancia.accion = false;
    }
}
