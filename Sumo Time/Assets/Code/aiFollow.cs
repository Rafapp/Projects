using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiFollow : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 playerPos;
    GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(player == null)
            player = GameObject.FindGameObjectWithTag("EditorOnly");
        if (player != null)
        {
            playerPos = player.transform.position;
            gameObject.GetComponent<NavMeshAgent>().SetDestination(playerPos);
        }
    }
}
