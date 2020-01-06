using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour, Iinteractable
{
    bool isUnlocked = false;
    bool shouldPlaySound = true;
    GameManager game;
    Animator anim;
    GameObject grandChild;
    AudioSource lockedSound;
    AudioSource unlockedSound;
   

    private void Start()
    {

        game = FindObjectOfType<GameManager>();
        anim = GetComponent<Animator>();
        grandChild = transform.GetChild(0).GetChild(0).gameObject;
        var aSources = GetComponents<AudioSource>();
        unlockedSound= aSources[0];
        lockedSound = aSources[1];
        
    }
    public void Interact()
    {
        if (game.getHasLockerKey())
        {
            isUnlocked = true;
            game.setHasLockerKey(false);
            unlockedSound.Play();
            shouldPlaySound = false;
        }
        else if (shouldPlaySound)
        {
            lockedSound.Play();
        }

        if (isUnlocked)
        {
            DoorChangeState();
        }
    }

    private void DoorChangeState()
    {
        if (anim.GetBool("isOpen"))
        {
            anim.SetBool("isOpen", false);
            gameObject.layer = 9;
            grandChild.layer = 0;
        }
        else
        {
            anim.SetBool("isOpen", true);
            gameObject.layer = 0;
            grandChild.layer = 9;
        }
    }
}
