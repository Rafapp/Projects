using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController cController;
    public Transform cam;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float smoothTurn;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float gravityForce;

    [SerializeField]
    private float jumpTime;

    private bool isJumping;


    public GameObject rootbone;

    public Vector3 moveDirection;

    float smoothVelocity;

    void Start()
    {

    }


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(-horizontal, 0f, -vertical).normalized;

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {

            float targetAngle = Mathf.Atan2(direction.x , direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, smoothTurn);

            moveDirection = Quaternion.Euler(0f, targetAngle + 180, 0f) * Vector3.forward;

            if (isJumping == false)
            {
                moveDirection = new Vector3(moveDirection.x, -gravityForce, moveDirection.z);
            }
            else if(isJumping == true){
                moveDirection = new Vector3(moveDirection.x, jumpForce, moveDirection.z);
            }

            
        }
        else if (isJumping == false)
        {
            moveDirection = new Vector3(0, -gravityForce, 0);
        }

        if (cController.isGrounded && Input.GetButtonDown("Jump"))
        {
            InvokeRepeating("jump", 0, .1f);
            Invoke("cancelJump", jumpTime);
        }

        cController.Move(moveDirection * speed * Time.deltaTime);
    }
    private void jump()
    {
        moveDirection = new Vector3(moveDirection.x, jumpForce, moveDirection.z);
        isJumping = true;
    }
    private void cancelJump()
    {
        isJumping = false;
        CancelInvoke("jump");
    }
}

    



