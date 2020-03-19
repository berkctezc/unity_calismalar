using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMovement : MonoBehaviour
{
    public float 
        forceMultiplier=1;

    private Rigidbody rigidbodyref;
    
    
    void Start()
    {
        rigidbodyref = GetComponent<Rigidbody>();
    }
    

    void FixedUpdate()
    {
        // user input
        rigidbodyref
            .AddForce(
                Input.GetAxis("Vertical") * forceMultiplier,
                0f,
                -Input.GetAxis("Horizontal") * forceMultiplier
            );
    }
}
