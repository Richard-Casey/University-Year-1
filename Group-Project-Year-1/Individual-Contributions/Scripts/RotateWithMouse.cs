using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fully aware that in most cases my comments are going to be longer than the code itself but this is more to show what it is i have actually learnt while writing these writes rather than
 * to remind myself of what they do later down the line*/

public class RotateWithMouse : MonoBehaviour
{
    public float turnSpeed = 2f; // Gave the camera rotation a float value to go along with the horizontal movement
  
    private void Update() // Update FPS
    {
        float horizontal = Input.GetAxis("Mouse X"); // Mouses X axis (note not vertical Y axis)
        transform.Rotate(horizontal * turnSpeed * Vector3.up, Space.World); // transforms the angle based on the horizontal float we assigned in the previous line of code
    }
}
