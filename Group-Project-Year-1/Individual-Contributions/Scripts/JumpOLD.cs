using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Fully aware that in most cases my comments are going to be longer than the code itself but this is more to show what it is i have actually learnt while writing these writes rather than
 * to remind myself of what they do later down the line*/

public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody; // To reference the rigidbody component that this script was originally intended to be attached too (The player controller)
    private float jumpForce = 400f; // This jump force was set at a time when gravcity for some reason was altered seemingly from the mesh's being introduced. The resulting force/gravily value
    // was implemented as a quick way to try and get around this. This issue was also very present and commmented on during are initial playable version of the game.
    private bool shouldJump; // created a condition in which to allow the spider to be able to jump

    private void Awake() => _rigidbody = GetComponent<Rigidbody>(); // used "Awake" instead of start as it gets called before start
            
    private void Update()
    {
        if (shouldJump == false)
            shouldJump = Input.GetKeyDown(KeyCode.Space); /* this was one of the first errors and i am willing to take full responsability of this. I wanted to hard code in the controls for
                                                           * the spider. My thought process for this would be that if i could teach myself to do this the more difficuly way and by using
                                                           * legacy controls, then using the new input system would be a lot easier and would also aid in bug fixing. However after switching
                                                           * to the new input system and finding that the only iussues were conflicts with the original legacy controls it just made a lot more
                                                           * sense to impliment the input system for funtionality.*/
    }

    private void FixedUpdate()
    {
        if (shouldJump)
        {
            _rigidbody.AddForce(jumpForce * Vector3.up); // So this was based on the coindition that the spider was touching the floor hense the "shouldJump" name. The force is an upwards one
                                                         // which would lauch the rigidbody upwards and create a jump.   
            shouldJump = false;
        }
    }
}
