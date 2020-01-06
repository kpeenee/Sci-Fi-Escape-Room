using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flasks : MonoBehaviour, Iinteractable
{
    [SerializeField] int value = 0;
    [SerializeField] Beaker beaker;
    AudioSource waterSound;

    private void Start()
    {
        waterSound = GetComponent<AudioSource>();
    }
    public void Interact()
    {
        beaker.ChangeCurrent(value);
        waterSound.Play();

    }
}
