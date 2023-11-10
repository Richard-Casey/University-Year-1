using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderClimb : MonoBehaviour
{
    public Transform chController; // I made this to basically void the new input system and use our own controls to take over in certain situations
    bool inside = false; // The first climbing mentod involved covering climbable surfaces with a collider which was set to be a trigger. This would
                         // then act as a primitive RayCast that when you were inside ther collider would instigate the climbing function
    public float climbingSpeed = 3.0f;
    public PlayerController chInput;



    // Start is called before the first frame update
    void Start()
    {
        chInput = GetComponent<PlayerController>();
        inside = false; // when spawned - not inside a collider
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Surface" && GetComponent<PlayerPickup>().currentPower == 1) //Condition of wall climbing. Tag has to be "Surface" and the PlayerPickup power needs to be 1
        { // went through and put box colliders on selected vertical surfaces - tagged them as "Surface" 
            chInput.enabled = false; // disables standard controls
            inside = !inside; //!inside avoids warnings of null reference at compile time
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Surface" && GetComponent<PlayerPickup>().currentPower == 1)
        {
            chInput.enabled = true; // turns the standard controls back on
            inside = !inside; // avoids null warning reference
            //GameObject.Find("Player").transform.rotation = Quaternion.Euler(0, 180, 0); -------------- This bit of code never worked!
            // User couldnt realistically exit the collider but was just stuck facing upwards. This ultimately confirmed my choice to explore Raycasting.

        }
    }

    void Update()
    {
        if (inside == true && Input.GetKey("w"))
        {
            chInput.transform.position += Vector3.up / climbingSpeed;
            GameObject.Find("Player").transform.rotation = Quaternion.Euler(90, 90, 0);
        }

        if (inside == true && Input.GetKey("s"))
        {
            chInput.transform.position += Vector3.down / climbingSpeed;
            GameObject.Find("Player").transform.rotation = Quaternion.Euler(-90, -90, 0);

        }

        /*( if (inside == true && Input.GetKey("a"))
         {
             chInput.transform.position += Vector3.left.normalized / climbingSpeed;
             GameObject.Find("Player").transform.rotation = Quaternion.Euler(90, 90, 0);
         }

         if (inside == true && Input.GetKey("d"))
         {
             chInput.transform.position += Vector3.right.normalized / climbingSpeed;
             GameObject.Find("Player").transform.rotation = Quaternion.Euler(-90, -90, 0);

         }*/
    }

}
