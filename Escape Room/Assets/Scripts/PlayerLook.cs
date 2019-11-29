using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float lookSensitivity = 150;
    [SerializeField] float maxClamp = 90f;
    [SerializeField] float minClamp = -90f;

    private float xAxisClamp;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.right);
        xAxisClamp = 0.0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotate();
    }

    private void CameraRotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * lookSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * lookSensitivity;

        xAxisClamp += mouseY;
        xAxisClamp = Mathf.Clamp(xAxisClamp, minClamp, maxClamp);

       
        if(xAxisClamp >= maxClamp)
        {
            mouseY = 0.0f;
            transform.eulerAngles = SetCameraRotation(maxClamp + 180);
        }
        else if(xAxisClamp <= minClamp)
        {
            mouseY = 0.0f;
            transform.eulerAngles = SetCameraRotation(minClamp + 180);
        }

        transform.Rotate(-Vector3.right * mouseY);
        transform.parent.Rotate(Vector3.up * mouseX);
        
    }

    private Vector3 SetCameraRotation(float value)
    {
        Vector3 curretnRotation = transform.eulerAngles;
        curretnRotation.x = value;
        return curretnRotation;
    }
}
