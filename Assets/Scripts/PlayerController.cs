using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //** OLD CODE! Keep as learning reference */

    // Vehicle movement speed no longer needed since using RigiBody physics
    // public float moveSpeed = 0.0f;

    public float turnSpeed = 0.0f;

    // Vehicle input axis for left/right
    public float horizontalInput;

    // Vehicle input axis for forward/backward
    public float verticalInput;


    //** NEW CODE! *//

    [SerializeField]
    private float horsePower = 100.0f;
  
    private Rigidbody playerRb;


    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        // Map axis input to "Horizontal"
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        //** OLD CODE! But keep as learning reference *//

        // Move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        // Turn/Steer the vehicle left or right - no rotation
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // Turn/Steer the vehicle forward or backward
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);


        //** NEW CODE! */

        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);

        // Turn/Steer the vehicle with transform.Rotate
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
