using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Private variables
    #region private vars
    
    [SerializeField] // Editable constants
    private float moveSpeed, smoothTurn, jumpForce;

    private float smoothVelocity, timer;

    private Vector2 move; // Movement vector from input manager

    private InputManager manager;

    private Rigidbody rb;

    private bool jumpButton;
    #endregion

    // Public variables
    #region public vars
    public Transform cam;

    public Vector3 moveDirection;

    public GameObject player, rootbone;
    #endregion

    private void Start()
    {
        manager = player.GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ManageRotationAndMovement();
        ManageJump();
    }
    private void ManageRotationAndMovement()
    {
        // Get the jump button from the input manager
        jumpButton = manager.JumpButton;

        // Movement vector from input joystick
        move = manager.movementVector;

        // Invert movement vector, discard y value and normalize it
        Vector3 direction = new Vector3(-move.x, 0, -move.y).normalized;

        // If we are moving
        if (move.magnitude > 0)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, smoothTurn);

            moveDirection = Quaternion.Euler(0f, targetAngle + 180, 0f) * Vector3.forward;

            rb.AddForce(moveDirection.x * moveSpeed * Time.deltaTime, 0, moveDirection.z * moveSpeed * Time.deltaTime);
        }
    }
    private void ManageJump()
    {
        // If we are jumping
        if (jumpButton == true)
        {
            timer += Time.deltaTime;

            // Raycast to ground to check for a ground
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f) && timer < .01f)
            {
                // Reset velocity, add vertical velocity for 1 milisecond
                rb.velocity = Vector3.zero;
                rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
            }
        }
        else
        {
            // Reset timer if not jumping
            timer = 0;
        }
    }
}

    



