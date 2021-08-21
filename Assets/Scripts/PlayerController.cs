using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    [SerializeField]
    GameObject centerOfMass;

    private Rigidbody playerRb;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    // UI
    [SerializeField]
    TMP_Text spedometerText;

    
    public float speed = 0.0f;

    [SerializeField]
    TMP_Text rpmText;

    public float rpm = 0.0f;



    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        // RigiBidy centerOfMass is not "this" centerOfMass so added this to be clear
        playerRb.centerOfMass = this.centerOfMass.transform.position;
    }

    
    void FixedUpdate()
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

        if(IsOnGround())
        {
            //** NEW CODE! */

            playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);

            // Turn/Steer the vehicle with transform.Rotate
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

            // UI

            // Speedometer - MPH
            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            spedometerText.SetText("Speed: " + speed + " mph");

            // RPM
            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
