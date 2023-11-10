using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    /* Fully aware that in most cases my comments are going to be longer than the code itself but this is more to show what it is i have actually learnt while writing these writes rather than
 * to remind myself of what they do later down the line*/

    /* This was my first attempt as writing legacy movement controls, it worked but just not well. This was done in the first week of the group project as by the second week i had contracted
     * COVID-19. When i returned it wouldnt work at it was at war with the input system and the cinemachine camera that had tried to be put in over the top of it.*/

    private Rigidbody _rigidbody; // names the rigidbody assigned top the player.
    public float MovementSpeed = 10.0f; // Set the speed of Vlad to 5. Can be changed in the editor.
    public float MovementForce = 10.0f; // The idea behind this was originally a momentum based movement - maybe for clearing jumps. At the time of implimentation i
    // didnt know how ambitious this would be or even if it would be needed

    private void Awake() => _rigidbody = GetComponent<Rigidbody>();

    /* So the below bit of code was one of 2 ways i was trying to impliemnt the movement of the spider, i learnt that one moves the spider in the world around them while the other moves them on
     * the axis. Given that the below is commented out and the Update() version remains it looks like i decided on the latter!

    /*private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            _rigidbody.AddForce(MovementForce * Vector3.forward);

        if(Input.GetKey(KeyCode.S))
            _rigidbody.AddForce(MovementForce * Vector3.back);

        if(Input.GetKey(KeyCode.A))
            _rigidbody.AddForce(MovementForce * Vector3.left);

        if(Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(MovementForce * Vector3.right);
    }*/


    void Update()
    {
        /* I implemented the time.deltatime * MovementSpeed which i learnt from the 2D game that we completed in the previous term*/

        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * MovementSpeed * transform.right; //Vector 3 respresents the 3d world and moves in a 3d space NOT the space local to the object

        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * MovementSpeed * -transform.right; // after a bunch of researching i found that a minus transform.right is left and a minus transfrom.forward is back

        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * MovementSpeed * transform.forward; // As above

        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * MovementSpeed * -transform.forward; // As above

        if (Input.GetKeyDown(KeyCode.Escape))
            Debug.Log("Vlad go bye-bye and night-nights. . . ."); // THIS WILL NOT WORK IN UNITY - Debug.Log line added to show visual representation that key is registered
        Application.Quit();

        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(0); // This was the respawn function that was first implemented before we had got to the use of the menus in game and the start menu

        // The below comment obviously didnt happen, but i did learn the different between the GetKey and the GetKeyDown bits of code.


        /* Wanted to be able to do this manually and through legacy, decided on
         using the "GetKey" instead of "GetKeyDown" as Getkey will call the input 
        every frame where as GetKeyDown will only acknowledge the button press once. */

        // Used GetKeyDown for reswpawn and application quit functions 


    }
}