using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOpen : MonoBehaviour,Iinteractable
{
    [SerializeField] CodeLock[] code;

    public void Interact()
    {
        
        foreach (CodeLock locking in code)
        {
            if (!locking.isCorrect())
            {
                return;
            }
            
        }
        Debug.Log("unlocked");
    }
}
