using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour, Iinteractable
{
    private string show = "Computer";
    [SerializeField] private GameObject interactWith;

    public void Interact()
    {
        Animator door = interactWith.GetComponent<Animator>();
        if (door.GetBool("isOpen"))
        {
            Debug.Log("Opening");
            door.SetBool("isOpen", false);
        }
        else
        {
            Debug.Log("Closing");
            door.SetBool("isOpen", true);
        }
        
    }
}
