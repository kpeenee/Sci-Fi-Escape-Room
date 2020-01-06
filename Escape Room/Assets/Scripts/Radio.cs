using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, Iinteractable
{
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void Interact()
    {
        audio.Play();
    }
}
