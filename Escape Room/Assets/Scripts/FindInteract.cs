using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindInteract : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] LayerMask interactableLayer;
    [SerializeField] float distance = 1f;
    [SerializeField] Text interactText;
    [SerializeField] Canvas interactCanvas;

    Iinteractable currentInteractable;

    private void Update()
    {
        LookForObject();
        Interact();
    }

    private void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentInteractable != null)
            {
                Debug.Log("Yep");
                currentInteractable.Interact();
            }
        }
    }

    private void LookForObject()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f,0.5f,0));
        RaycastHit hitInfo;
        if(Physics.Raycast(ray,out hitInfo, distance, interactableLayer))
        {
            currentInteractable = hitInfo.collider.GetComponent<Iinteractable>();
            interactCanvas.enabled = true;
            interactText.text = "Press E to interact";
        }
        else
        {
            currentInteractable = null;
            interactCanvas.enabled = false;
        }
    }
}
