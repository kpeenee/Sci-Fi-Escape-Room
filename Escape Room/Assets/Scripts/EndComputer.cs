using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndComputer : MonoBehaviour, Iinteractable
{
    public void Interact()
    {
       if (FindObjectOfType<GameManager>().GetHasCode())
        {
            Cursor.lockState = CursorLockMode.None;
            FindObjectOfType<SceneLoader>().LoadMainMenu();
        }
        else
        {
            FindObjectOfType<Indicate>().SetIndicator("I need to fond the code to escape");
        }
    }
}
