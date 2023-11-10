using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 3.0f;
    public float GroundLevel;
    public Vector2 movementVector;
    private const float gravity = -9.8f;
    public bool grounded = true;
    public float JumpSpeed = 6.0f;
    public int maxHealth = 100;
    public int currentHealth;
    private Rigidbody2D _rb;
    public HealthBar healthBar;
    public AudioSource audiosource;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
       if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }
        else if (Keyboard.current.enterKey.wasPressedThisFrame)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }


        float xPos = transform.position.x;
        float yPos = transform.position.y;

        if (movementVector.y > 1.0f)
            movementVector.y = 1.0f;

        /*if (grounded == false)
            {                movementVector.y += gravity * Time.deltaTime;
            }*/

        //float newY = yPos + movementVector.y;

        RaycastHit2D rayHit = Physics2D.Raycast(transform.position, new Vector3(0.0f, -1.0f), 0.6f, ~LayerMask.GetMask("Player"));
        RaycastHit2D rayHitLeft = Physics2D.Raycast(transform.position - new Vector3(0.2f, 0.0f), new Vector3(0.0f, -1.0f), 0.6f, ~LayerMask.GetMask("Player"));
        RaycastHit2D rayHitRight = Physics2D.Raycast(transform.position + new Vector3(0.2f, 0.0f), new Vector3(0.0f, -1.0f), 0.6f, ~LayerMask.GetMask("Player"));
        Debug.DrawLine(transform.position, transform.position + (new Vector3(0.0f, -1.0f) * 0.6f), Color.red, 1.5f);
        Debug.DrawLine(transform.position - new Vector3(0.2f, 0.0f), (transform.position - new Vector3(0.2f, 0.0f)) + (new Vector3(0.0f, -1.0f) * 0.6f), Color.red, 1.5f);
        Debug.DrawLine(transform.position + new Vector3(0.2f, 0.0f), (transform.position + new Vector3(0.2f, 0.0f)) + (new Vector3(0.0f, -1.0f) * 0.6f), Color.red, 1.5f);

        if (rayHit || rayHitLeft || rayHitRight)
        {
            grounded = true;
        } else
        {
            grounded = false;
        }

        /*if (newY < GroundLevel)
        {
            newY = GroundLevel;
            grounded = true;
        }*/


            transform.position = new Vector3(
            xPos + movementVector.x * MovementSpeed * Time.deltaTime,
            yPos);

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            TakeDamage(10);
        }

    }

    public void OnMove(InputValue input)
    {
        movementVector = input.Get<Vector2>();
    }

    public void OnJump(InputValue input)
    {
        if (input.isPressed && grounded)
        {
            _rb.AddForce(new Vector2(0.0f, JumpSpeed), ForceMode2D.Impulse);
            //movementVector.y = JumpSpeed * Time.deltaTime;
            grounded = false;

            audiosource.Play();

        }
    }

    void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }


}
