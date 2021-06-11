using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{ 
    // Reference to the propeller Game Object
    public GameObject propeller;

    // Rotation Speed of propeller
    public float propellerSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate propeller
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime, Space.Self);
    }
}
