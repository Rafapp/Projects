using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoTargetRotation : MonoBehaviour
{

    private Vector2 move;

    [SerializeField]
    private float smoothTurn;

    [SerializeField]
    bool halfRotation;

    public Transform cam;

    float smoothVelocity;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        move = player.GetComponent<InputManager>().movementVector;

        float horizontal = move.x;

        float vertical = move.y;

        Vector3 direction = new Vector3(-horizontal, 0f, -vertical).normalized;

        if (move.magnitude > 0)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, smoothTurn);

            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
    }
}
