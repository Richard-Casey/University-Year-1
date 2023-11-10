using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    /* The below is the original player controller that i then rewrote after we switched to the newer input system*/

    private Vector3 movementVector; // Vector used in line with movement
    private const float gravity = -9.81f; // gravity value after fixing issues with legacy controls and gravity needing to be set to -2000
    public float MovementSpeed = 2.0f; // initial value of 2.0f which is used for the movement speed
    public float GroundLevel = 2.3f; // after some tweaking with the y axis of the floor 2.3 was a goiod number to make the spider appear level with the floor
    private bool grounded = true; // boolean created to confiorm if grounded - again originally to be used with the jump function
    public float JumpSpeed = 6.0f; // Float assigned to be the speed of the jump

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x; // the transfrom.position.x is asssigned to the float value of xPos
        float yPos = transform.position.y; // same as above but for yPos

        if (grounded == false) // if grounded is exactly false then proceed with if statement if not continue to float newY ...
        {
            movementVector.y += gravity * Time.deltaTime;
        }

        float newY = yPos + movementVector.y; // float newY is the result of yPos plus movementvector.y

        if (newY < GroundLevel) // if the resulting newY variable is less that ground level then it gets changed back to ground level
            newY = GroundLevel; // This helped initially but then i ran into the issue that if our character was not touching the ground they could not jump like standing on the table etc.

        transform.position = new Vector3(xPos + movementVector.x * MovementSpeed * Time.deltaTime,
                                         newY); 
    }

    public void OnMove(InputValue input)
    {
        movementVector = input.Get<Vector2>(); // Pretty sure i didnt fully understand Vectors at this point.
    }

    public void OnJump(InputValue input) // Jump mechanic
    {
        if(input.isPressed && grounded) // check to see if jump conditions are met
        {
            movementVector.y = JumpSpeed * Time.deltaTime; // y being vertical equals JumpSpeed multiplied by Timer.deltaTime
            grounded = false; // grounded then becomes false so another jump can not be performed while already jumping
        }
    }
}