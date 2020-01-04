using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoor : MonoBehaviour, Iinteractable
{
    Locker grandFather;

    private void Start()
    {
        grandFather = transform.parent.parent.GetComponent<Locker>();
    }
    public void Interact()
    {
        grandFather.Interact();
    }
}
