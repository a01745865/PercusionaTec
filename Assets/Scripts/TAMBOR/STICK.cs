using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STICK : MonoBehaviour
{

    //Animator
    private Animator animator;

    //Para el animator
    bool sonido = false;

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
        if (Input.GetKeyDown(KeyCode.S))
        {
            sonido = true;
            audioSource.Play(0);
        }

        if (!audioSource.isPlaying)
        {
            sonido = false;
            audioSource.Stop();
        }
    }

    private void FixedUpdate()
    {
        //Animator
        
        animator.SetBool("sonido", sonido);
        
    }


}
