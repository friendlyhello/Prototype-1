using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Game Object reference to the Vehicle
    public GameObject player;

    // 
    public Vector3 offset = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate allows the vehicle to move first, and then the camera - no more jitter
    void LateUpdate()
    {
        // Set camera transform/position to the vehicle reference transform/position

        // Add a (temporary) "new" Vector3 to add an offset to the camera
        transform.position = player.transform.position + offset;
    }
}
