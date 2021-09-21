using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoTargetRotation : MonoBehaviour
{
    [SerializeField]
    private float smoothTurn;

    [SerializeField]
    bool halfRotation;

    public Transform cam;

    float smoothVelocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(-horizontal, 0f, -vertical).normalized;

        if (direction.magnitude >= 0.1)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, smoothTurn);
           
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
    }
}
