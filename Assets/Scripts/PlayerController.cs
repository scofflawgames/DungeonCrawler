using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //input
    float horizontalMove = 0;
    float verticalMove = 0;
    float horizontalRotate = 0;
    float verticalRotate = 0;
    const float mouseSensitivity = 3;

    //movement
    const float maxSpeed = 4;
    const float moveForce = 10;

    //components
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
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        horizontalRotate = Input.GetAxis("Mouse X");
        verticalRotate = Input.GetAxis("Mouse Y");
    }

    void HandleMovement()
    {
        //rotate the player
        transform.RotateAround(transform.position, -transform.up, horizontalRotate * mouseSensitivity);

        //only the camera rotates up and down
        Vector3 camRotation = transform.GetChild(0).transform.rotation.eulerAngles;

        if (camRotation.x + -verticalRotate * mouseSensitivity > 330 || camRotation.x + -verticalRotate * mouseSensitivity < 30)
        {
            transform.GetChild(0).transform.RotateAround(transform.position, transform.right, -verticalRotate * mouseSensitivity);
        }

        //move the player in a certain direction
        if(horizontalMove * rb.velocity.x < maxSpeed)
        {
            rb.AddForce(transform.right * horizontalMove * moveForce);
        }

        if (verticalMove * rb.velocity.y < maxSpeed)
        {
            rb.AddForce(transform.forward * verticalMove * moveForce);
        }

        //slow the player down if they're moving too fast
        if(Mathf.Abs(rb.velocity.x) > maxSpeed)
        {
            rb.velocity = new Vector3(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        }

        if (Mathf.Abs(rb.velocity.y) > maxSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, Mathf.Sign(rb.velocity.y) * maxSpeed);
        }
    }
}
