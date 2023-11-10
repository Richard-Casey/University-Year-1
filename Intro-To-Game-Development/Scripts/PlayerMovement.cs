using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour

{   public Animator animator;

    private void Update()
    {
       /* animator.SetBool("bool", true);
        animator.SetFloat("float", 1.0f);
        animator.SetInteger("int", 1);
        animator.SetTrigger("trigger");
       */
        animator.SetFloat("XSpeed", Mathf.Abs(Input.GetAxis("Horizontal")));
        animator.SetBool("Grounded", gameObject.GetComponent<PlayerController>().grounded);

        /*if (gameObject.GetComponent<PlayerController>().grounded == false)
        {
            animator.Play("Player_Jump");
        }

        else
        {
            animator.SetBool("Grounded", gameObject.GetComponent<PlayerController>().grounded); 
        }*/
       

    }

    /*public void OnMove(InputAction.CallbackContext context)
    {
        float tempx = context.ReadValue<Vector2>().x;
        animator.SetFloat("XSpeed", Mathf.Abs(tempx));
    }*/
}

