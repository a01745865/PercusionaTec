using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Script que borra una mano transcurrida la música y pone otra
 * Autores: Erika Marlene García Sánchez, César Emiliano Palome Luna, Jose Angel Garcia Gomez y José Luis Madrigal Sánchez
 */
public class ManoIzq : MonoBehaviour
{

    //Animator
    private Animator animator;

    //Para el animator
    public bool sonido = false;

    //IsPlaying
    public AudioClip otherClip;
    AudioSource audioSource;


    public bool visibilidadMano = true;


    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            sonido = true;
            audioSource.Play(0);
        }

        if (!audioSource.isPlaying)
        {
            sonido = false;
            //audioSource.Stop();
        }
    }

    private void FixedUpdate()
    {
        //Animator

        animator.SetBool("sonido", sonido);

    }


}



