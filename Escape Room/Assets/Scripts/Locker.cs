using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour, Iinteractable
{
    bool isUnlocked = false;
    GameManager game;
    Animator anim;
    GameObject grandChild;
   

    private void Start()
    {
        game = FindObjectOfType<GameManager>();
        anim = GetComponent<Animator>();
        grandChild = transform.GetChild(0).GetChild(0).gameObject;
        
    }
    public void Interact()
    {
        if (game.getHasLockerKey())
        {
            isUnlocked = true;
            game.setHasLockerKey(false);
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
