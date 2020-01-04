using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaker : MonoBehaviour, Iinteractable
{
    [SerializeField] int currentValue = -2;
    [SerializeField] Material[] materials;
    [SerializeField] GameObject liquid;
    [SerializeField] GameObject key;

    public void Interact()
    {
        if(currentValue == 0)
        {
            FindObjectOfType<GameManager>().setHasLockerKey(true);
            Destroy(key);
        }
    }

    public void ChangeCurrent(int value)
    {
        currentValue += value;
        if(currentValue < -2)
        {
            currentValue = -2;
        }
        else if(currentValue > 2)
        {
            currentValue = 2;
        }

        ChangeColour();
    }

    private void ChangeColour()
    {
        liquid.GetComponent<Renderer>().material = materials[currentValue + 2];
    }
}
