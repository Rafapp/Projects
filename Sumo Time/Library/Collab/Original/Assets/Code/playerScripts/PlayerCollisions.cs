using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    //publics
    public GameObject player;

    //privates
    private PlayerMovement MoveScript;

    [SerializeField]
    private float pushForce;

    void Start()
    {
        MoveScript = player.GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collision between players!");
            other.gameObject.GetComponentInParent<Rigidbody>().AddForce(other.GetComponentInParent<PlayerMovement>().moveDirection * pushForce);
        }
        else if (other.tag == "die")
        {
            Debug.Log("dead");
            Vector3 sphere = Random.insideUnitSphere;
            player.transform.position = new Vector3(sphere.x, 25, sphere.z);
        }
    }
}
