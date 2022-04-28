using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MARACA2 : MonoBehaviour
{
    //Animator
    private Animator animator;

    //Para el animator
    public bool accion = false;

    //IsPlaying
    public AudioClip otherClip;
    AudioSource audioSource;



    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        animator.SetBool("accion", accion);
        animator.SetBool("sonido", false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            accion = true;
            animator.SetBool("accion", accion);
            audioSource.Play(0);

        }

        if (!audioSource.isPlaying)
        {
            accion = false;
            animator.SetBool("accion", accion);

        }
    }

}
