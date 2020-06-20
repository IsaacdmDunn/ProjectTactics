using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
 
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.V) && (cam1.enabled == true || cam2.enabled == false))
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.V) && (cam2.enabled == true || cam1.enabled == false))
        {
            cam2.enabled = false;
            cam1.enabled = true;
        }
    }
}
