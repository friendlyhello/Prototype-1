using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Vehicle movement speed
    public float moveSpeed = 0;

    // Vehicle turn speed
    public float turnSpeed = 0;

    // Vehicle input axis for left/right
    public float horizontalInput;

    // Vehicle input axis for forward/backward
    public float verticalInput;

    
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Map axis input to "Horizontal"
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        // Turn/Steer the vehicle left or right
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // Turn/Steer the vehicle forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
    }
}
