using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float xMouse, yMouse;
    
    void Update()
    {
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y");
        transform.Rotate(-yMouse, 0, 0);
        transform.Rotate(0, xMouse, 0, Space.World);
    }
}
