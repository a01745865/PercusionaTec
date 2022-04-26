using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STICK2 : MonoBehaviour
{

    //Animator
    private Animator animator;

    //Para el animator
    public bool sonido = false;
    public bool accion = false;

    public GameObject SonidoCompleto;
    public GameObject SonidoAccion;

    public static STICK2 instancia;

    void Awake()
    {
        instancia = this;
    }
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.S))
        {
            sonido = true;
            Instantiate(SonidoCompleto);

        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            accion = true;
            Instantiate(SonidoAccion);

        }


    }

    private void FixedUpdate()
    {
        //Animator

        animator.SetBool("sonido", sonido);
        animator.SetBool("accion", accion);
    }


}
