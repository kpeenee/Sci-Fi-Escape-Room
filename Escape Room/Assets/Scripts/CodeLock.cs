using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour,Iinteractable
{
    [SerializeField] int currentValue = 0;
    [SerializeField] int correctValue;
    AudioSource changeSound;

    private void Start()
    {
        changeSound = GetComponent<AudioSource>();
    }
    public void Interact()
    {
        currentValue += 1;
        transform.Rotate(0, 0, -72);
        if(currentValue > 4)
        {
            currentValue = 0;
        }
        changeSound.Play();
    }

    public bool isCorrect()
    {
        if (currentValue == correctValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
}
