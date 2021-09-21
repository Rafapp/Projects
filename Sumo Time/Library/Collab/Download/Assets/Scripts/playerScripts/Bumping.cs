using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumping : MonoBehaviour
{
    public GameObject ControllerObject;

    private CharacterController cController;

    private movement MoveScript;

    [SerializeField]
    private float pushForce;

    [SerializeField]
    private float pushTime;

    private bool isPushing;
    void Start()
    {
        cController = ControllerObject.GetComponent<CharacterController>();
        MoveScript = ControllerObject.GetComponent<movement>();
    }

    
    void Update()
    {
        if (isPushing) {
            cController.Move(new Vector3(MoveScript.moveDirection.x * -1 * pushForce, 0, MoveScript.moveDirection.z * -1 * pushForce).normalized);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isPushing = true;
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player")
        {
            isPushing = false;
        }
    }
}
