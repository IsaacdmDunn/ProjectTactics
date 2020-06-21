using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //camera objects
    public Camera cam1;
    public Camera cam2;
    public GameObject cameraObject;

    float x = 4.5f, y = 4.5f;
    
    float cameraRotation;
 
    //set camera to iso when game starts
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    //update every frame
    void Update()
    {
        //switch between iso and top-down view by pressing V
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

        //moves camera with WASD
        if (Input.GetKey(KeyCode.W)) {
            y += 0.05f;
        }
        else if (Input.GetKey(KeyCode.S)) {
            y -= 0.05f;
        }
        if (Input.GetKey(KeyCode.A)) {
            x -= 0.05f;
        }
        else if (Input.GetKey(KeyCode.D)) {
            x += 0.05f;
        }

        //rotates camera
        if (Input.GetKeyDown(KeyCode.Q)) {
            cameraRotation -= 90;
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            cameraRotation += 90;
        }
        //light.transform.rotation = Quaternion.Euler(0, lightRotation, 0);
        transform.rotation = Quaternion.Euler(0, 0, cameraRotation);
        transform.position = new Vector3(x, y, 0);
    }
}
