using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoop : MonoBehaviour
{
    public AudioSource pooping;

    private void Awake()
    {
        pooping = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            pooping.Play();
        }
    }
}