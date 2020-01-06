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
        transform.parent.parent.gameObject.GetComponent<Animator>().SetBool("isOpen", true);
        FindObjectOfType<GameManager>().setHasCode(true);
        FindObjectOfType<Indicate>().SetIndicator("I got the code to escape");
    }
}
