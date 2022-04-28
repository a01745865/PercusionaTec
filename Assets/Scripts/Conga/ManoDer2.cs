using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoDer2 : MonoBehaviour
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
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            accion = true;
            audioSource.Play(0);

        }

        if (!audioSource.isPlaying)
        {
            accion = false;

        }

    }

    private void FixedUpdate()
    {
        //Animator

        animator.SetBool("accion", accion);
    }
}
