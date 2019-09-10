using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput = 0;
    float verticalInput = 0;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        HandleInput();
    }


    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void HandleMovement()
    {
        //rb.position = new Vector3(rb.position.x, rb.position.y, rb.position.z + verticalInput * 0.1f);
        //rb.rotation = Quaternion.Euler(new Vector3(rb.rotation.x, rb.rotation.y + horizontalInput, rb.rotation.z));
        Vector3 eulerRotation = rb.rotation.eulerAngles;
        eulerRotation.y += horizontalInput;
        rb.rotation = Quaternion.Euler(eulerRotation);
        //rb.AddForce(Vector3.forward * verticalInput * 40, ForceMode.Force);
        //rb.position +=
    }
}
