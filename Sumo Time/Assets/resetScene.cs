using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour
{
    public GameObject player;
    public void Reset()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("EditorOnly");
        Vector3 sphere = Random.insideUnitSphere;
        player.transform.position = new Vector3(sphere.x, 25, sphere.z);
    }
}
