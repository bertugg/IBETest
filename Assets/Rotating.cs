using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public float xRotationSpeed, yRotationSpeed, zRotationSpeed;
    
    void Update()
    {
        transform.Rotate(xRotationSpeed * Time.deltaTime, 
            yRotationSpeed * Time.deltaTime, 
            zRotationSpeed * Time.deltaTime);
        
        // Time.deltaTime: her bir frame arasında geçen süreyi yansıtır
    }
}
