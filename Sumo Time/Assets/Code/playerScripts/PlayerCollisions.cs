using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Publics
    public GameObject player;

    // Privates
    private PlayerMovement myMovement;
    private PlayerMovement enemyMovement;

    [SerializeField] // Force with which the players get pushed
    private float pushForce = 2500;

    void Start()
    {
        myMovement = player.GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponentInParent<Rigidbody>().AddForce(new Vector3(-GetComponentInParent<Rigidbody>().velocity.x, 0, -GetComponentInParent<Rigidbody>().velocity.z)  * pushForce);
            other.GetComponentInParent<Rigidbody>().AddForce(new Vector3(GetComponentInParent<Rigidbody>().velocity.x, 0, GetComponentInParent<Rigidbody>().velocity.z) * pushForce);
        }
        if (other.tag == "die")
        {
            Vector3 sphere = Random.insideUnitSphere;
            player.transform.position = new Vector3(sphere.x, 25, sphere.z);
        }
    }
}
