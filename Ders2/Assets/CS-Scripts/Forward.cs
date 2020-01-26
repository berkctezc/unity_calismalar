using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{

    public float 
        thrustX,
        thrustY,
        thrustZ
        ;

    private Rigidbody rigidbodyref;
    
    // Start is called before the first frame update
    void Start()
    {
        //kendi rigidbodysine erişiyor
        rigidbodyref = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //her karede fizik hesaplarından önce yapılacak işlemler
    void FixedUpdate()
    {
        rigidbodyref
            .AddForce(
            thrustX,
            thrustY,
            thrustZ
            );
    }
}

