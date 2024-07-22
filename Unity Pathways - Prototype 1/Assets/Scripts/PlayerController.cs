using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInput;
    
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        // We turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
