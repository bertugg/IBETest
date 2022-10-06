using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolController : MonoBehaviour
{
    public Vector3 offset;
    public float speed;
    public Vector3 targetPosition;
    public Vector3 startPosition;
    public bool hasArrived;

    public float passedTime;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = transform.position + offset;
        hasArrived = false;
    }

    void Update()
    {
        // Translate
        /*
        if (hasArrived != true)
        {
            transform.Translate(offset.normalized * speed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, targetPosition) < 0.3f)
                hasArrived = true;
        }
        else
        {
            transform.Translate(-offset.normalized * speed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, startPosition) < 0.3f)
                hasArrived = false;
        }
        */
        
        // LERP
        
        passedTime += Time.deltaTime * speed / 10;
        
        if (hasArrived != true)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, passedTime);
            if (passedTime > 1)
            {
                passedTime = 0;
                hasArrived = true;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(targetPosition, startPosition, passedTime);
            if (passedTime > 1)
            {
                passedTime = 0;
                hasArrived = false;
            }
        }
        
    }
}
