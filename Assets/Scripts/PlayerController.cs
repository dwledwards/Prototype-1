using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of vehicle
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    float horizontalInput;
    float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get value of horizontal axis when pressed
        horizontalInput = Input.GetAxis("Horizontal");
        // Get value of veritical axis when pressed
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn vehicle left and right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
