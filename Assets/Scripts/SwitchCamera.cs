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
        if (Input.GetKeyDown(KeyCode.C) && !cameraIsFPS)
        {
            cameraIsFPS = true;
            camera2.SetActive(true);
            camera1.SetActive(false);
            Debug.Log("FPS Camera 2 Active");
        }

        else if (Input.GetKeyDown(KeyCode.C) && cameraIsFPS)
        {
            cameraIsFPS = false;
            camera2.SetActive(false);
            camera1.SetActive(true);
            Debug.Log("Gameplay Camera 1 Active");
        }
    }
}
