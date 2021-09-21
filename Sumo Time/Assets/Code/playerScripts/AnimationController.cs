using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : MonoBehaviour
{
    private Vector2 move;

    private InputManager manager;

    [SerializeField]
    private GameObject player;
    private void Start()
    {
        manager = player.GetComponent<InputManager>();
    }

    void Update()
    {
        move = manager.movementVector;

        if (move.x != 0 || move.y != 0)
        {
            GetComponent<Animator>().Play("Run");
        }
        else {
            GetComponent<Animator>().Play("Idle");
        }
    }
}
