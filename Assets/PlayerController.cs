using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Float: 0.2f 1f 1000f 256.456f
    // Int: 0 -100 256
    // String: "Horizontal" "Alican"
    // Bool: true, false
    // Vector3: {-4.2f, 24f, 100,2f}, {0,0,0}

    public float movementSpeed;
    public float jumpForce;
    public int score;

    Rigidbody myRigidBody; // Degisken tanımlama
    
    void Start()
    {
        score = 0;
        myRigidBody = GetComponent<Rigidbody>(); // Atama ve component bulma
    }

    // Her Frame'de çalışır
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed; // Degisken tanımlama ve atama
        float verticalMovement = Input.GetAxis("Vertical") * movementSpeed;
        
        myRigidBody.velocity = new Vector3(horizontalMovement, myRigidBody.velocity.y, verticalMovement); // Hareket etmesi

        if (Input.GetKeyDown(KeyCode.Space)) // Ziplamasi
        {
            myRigidBody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            GameObject.Destroy(this.gameObject);
            Debug.Log("GAME OVER");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart Scene Code
        }
        else if (other.gameObject.CompareTag("Platform"))
        {
            transform.SetParent(other.transform);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            transform.SetParent(null);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            GameObject.Destroy(other.gameObject);
            score = score + 1;
        }
    }
}