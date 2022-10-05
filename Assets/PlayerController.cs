using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Float: 0.2f 1f 1000f 256.456f
    // Int: 0 -100 256
    // String: "Horizontal" "Alican"
    // Bool: true, false
    // Vector3: {-4.2f, 24f, 100,2f}, {0,0,0}

    Rigidbody myRigidBody; // Degisken tanımlama
    
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>(); // Atama ve component bulma
    }

    // Her Frame'de çalışır
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal"); // Degisken tanımlama ve atama
        float verticalMovement = Input.GetAxis("Vertical");
        
        transform.Translate(horizontalMovement, 0, verticalMovement);
        //myRigidBody.AddForce(1,0,0);
            //new Vector3(horizontalMovement, myRigidBody.velocity.y, verticalMovement); // Topun hızını atama
    }
}