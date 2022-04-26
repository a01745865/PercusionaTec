using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STICK3 : MonoBehaviour
{
    //Animator
    private Animator animator;

    //Para el animator
    bool sonido = false;
    bool accion = false;

    public GameObject SonidoCompleto;
    public GameObject SonidoAccion;


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


        if (Input.GetKeyDown(KeyCode.A))
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
