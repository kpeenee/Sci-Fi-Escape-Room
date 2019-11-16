using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 foward = transform.forward * inputY * moveSpeed;
        Vector3 side = transform.right * inputX * moveSpeed;
        Vector3 up = new Vector3(0, rb.velocity.y, 0);

        rb.velocity = foward + side + up;
       
    }
}
