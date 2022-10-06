using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Vector3 startAngle, targetAngle;
    public float passedTime = 0;

    public Quaternion myRotation;
    
    void Start()
    {
        startAngle = transform.rotation.eulerAngles;
        targetAngle = startAngle + new Vector3(0, 90, 0);
    }

    void Update()
    {
        myRotation = transform.rotation;
        transform.rotation = Quaternion.Euler(Vector3.Lerp(startAngle, targetAngle, passedTime));
        passedTime += Time.deltaTime;
    }
}
