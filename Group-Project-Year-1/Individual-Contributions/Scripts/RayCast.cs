using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This bit of code took me quite a while but i was very pleased at how it turned out and actually very proud of myself also. This took over the "SpiderClimb" script and was essentially my second attempt at all climbing.

public class RayCast : MonoBehaviour
{
    public bool touchingSurfaceFront = false; // So when the game starts the raycast from the front of the spider is set to false as it is not touching anything
    public bool touchingGround = false; // Second raycast coming from below the spider to see if they are touching the floor. The spider spawns floating slightly so this raycast is actually false to begin with.
    public float climbingSpeed = 3.0f; //  Set a float value for a climbing speed
    public PlayerController chInput; // This is what i wanted to use to start with the take over from the input control system to make the spider to up and down instead of forward and back
    public Transform chController; // As above
    public float spiderspeed = 50.0f; // Spiders movement speed
    public Rigidbody rb; // Reference to the rigidbody


    // Update is called once per frame
    void Update()
    {
        
       if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out RaycastHit hitInfoFront, 3f) && GetComponent<PlayerPickup>().currentPower == 1)
            //This is the raycast out of the front of the spider. The TransfromDirection(Vector3.back) is used because the spider was initially imported at an angle which resulted in them
            //standing on their head. The condition is also upon obtaining the first powerup (or fly) that would then allow the player to be able to climb surfaces
        {
            touchingSurfaceFront = true; // If the raycast confirms that something is in front of the spider 
            touchingGround = true; // this confirms that they are also touching the floor
            //rb = GetComponent<Rigidbody>();
            //rb.AddForce(100, 0, 0, ForceMode.Force);

            Debug.Log("Hit Something"); // A visual reperesentation of the raycast displayed in the console upon running the game
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * hitInfoFront.distance, Color.red); // again because of the importation of the original spider, Vector3.back
                                                                                                                              // actually Raytcast in front of our spider
        }

       else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hitInfoDown, 3f)) // This was basically as double check to see if the spider was on the floor
                                                                                                                                 // - if this was true then they were touching a solid surface
        {
            touchingGround = true;
            Debug.Log("Hit Something");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * hitInfoDown.distance, Color.red);
        }

       else
        {
            touchingGround = false; // if not toching the floor
            touchingSurfaceFront = false; // if there is not a surface directly in front of them
            Debug.Log("Hit Nothing");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * 3f, Color.green);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 3f, Color.green);

            // Essentially a bit of a failsafe as this would mean that the spider is floating or in the middle of a jump
        }

       if (touchingSurfaceFront == true && Input.GetKey("w")) // so if there is a surface in front of the spider and the user is inputting the "W" key
        {

            GameObject.Find("Player").transform.rotation = Quaternion.Euler(90, 90, 0); // spider rotates to the vertical position (again accounting for our imported spider)
            GameObject.Find("Player").GetComponent<PlayerController>().gravityValue = 0; // turned gravity off to allow for this - otherwise our spider was just pulled to
                                                                                         // the ground and wasnt allowed to actually climb anything but would just get stuck in the vertical position
           

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            GameObject.Find("Player").transform.position = transform.position + new Vector3(horizontalInput * spiderspeed * Time.deltaTime, verticalInput * spiderspeed * Time.deltaTime, 0);
        }

       /*else if (touchingSurfaceFront == true && Input.GetKey("s"))
        {

            GameObject.Find("Player").transform.rotation = Quaternion.Euler(-90, -180, 0);
            GameObject.Find("Player").GetComponent<PlayerController>().gravityValue = 0;

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            GameObject.Find("Player").transform.position = transform.position + new Vector3(horizontalInput * spiderspeed * Time.deltaTime, verticalInput * spiderspeed * Time.deltaTime, 0);
        }*/

       else
        {
            GameObject.Find("Player").GetComponent<PlayerController>().gravityValue = -100; // If not - put gravity back on!
        }

        



    }
}
