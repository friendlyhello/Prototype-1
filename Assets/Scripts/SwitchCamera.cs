using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    // Camera One - Gameplay View
    public GameObject camera1;

    // Camera Two - FPS
    public GameObject camera2;

    // Is this Camera the FPS Camera?
    bool cameraIsFPS = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && cameraIsFPS)
        {
            cameraIsFPS = false;
            camera2.gameObject.SetActive(true);
            camera1.gameObject.SetActive(false);
            Debug.Log("Camera 1 Active");
        }

        else if (Input.GetKeyDown(KeyCode.C) && !cameraIsFPS)
        {
            cameraIsFPS = true;
            camera2.gameObject.SetActive(false);
            camera1.gameObject.SetActive(true);
            Debug.Log("Camera 2 Active");
        }
    }
}
