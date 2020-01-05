using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndComputer : MonoBehaviour, Iinteractable
{
    public void Interact()
    {
       if (FindObjectOfType<GameManager>().GetHasCode())
        {
            FindObjectOfType<SceneLoader>().LoadMainMenu();
        }
    }
}
